using System.Drawing.Imaging;
using System.Runtime.InteropServices;

public class ConvolutionMatrix
{
    public ConvolutionMatrix()
    {
    }

    public static Bitmap ApplyConvMatrix(Bitmap bitmap, ConvMatrix matrix)
    {
        // Assumes Format24bppRgb
        Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);

        BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
            ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

        BitmapData resultData = result.LockBits(new Rectangle(0, 0, result.Width, result.Height),
            ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

        IntPtr bitmapPtr = bitmapData.Scan0;
        IntPtr resultPtr = resultData.Scan0;

        int byteCount = bitmapData.Stride * bitmap.Height;
        byte[] pixelValues = new byte[byteCount];
        byte[] resultValues = new byte[byteCount];

        Marshal.Copy(bitmapPtr, pixelValues, 0, byteCount);

        // initialize result with original pixels so borders remain unchanged
        Buffer.BlockCopy(pixelValues, 0, resultValues, 0, byteCount);

        int halfN = matrix.n / 2;
        int halfM = matrix.m / 2;

        // guard factor
        int factor = matrix.factor == 0 ? 1 : matrix.factor;

        for (int j = halfM; j < bitmap.Height - halfM; j++)      // y
        {
            for (int i = halfN; i < bitmap.Width - halfN; i++)   // x
            {
                int r = 0, g = 0, b = 0;

                for (int y = 0; y < matrix.m; y++)
                {
                    int yy = j + y - halfM;
                    int pixelY = yy * bitmapData.Stride;

                    for (int x = 0; x < matrix.n; x++)
                    {
                        int xx = i + x - halfN;
                        int pixelX = xx * 3;
                        int pixelIndex = pixelY + pixelX;

                        // safe because we only iterate in valid range
                        byte bVal = pixelValues[pixelIndex];
                        byte gVal = pixelValues[pixelIndex + 1];
                        byte rVal = pixelValues[pixelIndex + 2];

                        int k = matrix.matrix[x, y];

                        r += rVal * k;
                        g += gVal * k;
                        b += bVal * k;
                    }
                }

                r /= factor;
                g /= factor;
                b /= factor;

                r += matrix.offset;
                g += matrix.offset;
                b += matrix.offset;

                r = Math.Max(0, Math.Min(255, r));
                g = Math.Max(0, Math.Min(255, g));
                b = Math.Max(0, Math.Min(255, b));

                int resultIndex = (j * resultData.Stride) + (i * 3);
                resultValues[resultIndex + 2] = (byte)r;
                resultValues[resultIndex + 1] = (byte)g;
                resultValues[resultIndex] = (byte)b;
            }
        }

        Marshal.Copy(resultValues, 0, resultPtr, byteCount);

        bitmap.UnlockBits(bitmapData);
        result.UnlockBits(resultData);

        return result;
    }

    // Shrink: returns a bitmap half the width and half the height (average 2x2 pooling)
    public static Bitmap Shrink(Bitmap bitmap)
    {
        int w = bitmap.Width;
        int h = bitmap.Height;
        int nw = Math.Max(1, w / 2);
        int nh = Math.Max(1, h / 2);

        Bitmap result = new Bitmap(nw, nh, PixelFormat.Format24bppRgb);

        // Lock source and dest
        BitmapData srcData = bitmap.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
        BitmapData dstData = result.LockBits(new Rectangle(0, 0, nw, nh), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

        int srcStride = srcData.Stride;
        int dstStride = dstData.Stride;

        int srcByteCount = srcStride * h;
        int dstByteCount = dstStride * nh;

        byte[] srcBytes = new byte[srcByteCount];
        byte[] dstBytes = new byte[dstByteCount];

        Marshal.Copy(srcData.Scan0, srcBytes, 0, srcByteCount);

        for (int y = 0; y < nh; y++)
        {
            for (int x = 0; x < nw; x++)
            {
                // average 2x2 block from source
                int sx = x * 2;
                int sy = y * 2;

                int sumR = 0, sumG = 0, sumB = 0;
                int count = 0;

                for (int oy = 0; oy < 2; oy++)
                {
                    int yy = sy + oy;
                    if (yy >= h) continue;
                    int row = yy * srcStride;
                    for (int ox = 0; ox < 2; ox++)
                    {
                        int xx = sx + ox;
                        if (xx >= w) continue;
                        int idx = row + xx * 3;
                        sumB += srcBytes[idx];
                        sumG += srcBytes[idx + 1];
                        sumR += srcBytes[idx + 2];
                        count++;
                    }
                }

                byte avgB = (byte)(sumB / Math.Max(1, count));
                byte avgG = (byte)(sumG / Math.Max(1, count));
                byte avgR = (byte)(sumR / Math.Max(1, count));

                int dstIdx = y * dstStride + x * 3;
                dstBytes[dstIdx] = avgB;
                dstBytes[dstIdx + 1] = avgG;
                dstBytes[dstIdx + 2] = avgR;
            }
        }

        Marshal.Copy(dstBytes, 0, dstData.Scan0, dstByteCount);

        bitmap.UnlockBits(srcData);
        result.UnlockBits(dstData);

        return result;
    }

    public static Bitmap Sharpen(Bitmap bitmap)
    {
        ConvMatrix conv = new ConvMatrix(3, 3, new int[3, 3] { { 0, -2, 0 }, { -2, 11, -2 }, { 0, -2, 0 } }, 0, 3);
        return ApplyConvMatrix(bitmap, conv);
    }

    public static Bitmap Blur(Bitmap bitmap)
    {
        ConvMatrix conv = new ConvMatrix(3, 3, new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } }, 0, 9);
        return ApplyConvMatrix(bitmap, conv);
    }

    public static Bitmap StrongerBlur(Bitmap bitmap)
    {
        ConvMatrix conv = new ConvMatrix(5, 5, new int[5, 5] {
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 }
        }, 0, 25);
        return ApplyConvMatrix(bitmap, conv);
    }

    public static Bitmap EdgeEnhance(Bitmap bitmap)
    {
        ConvMatrix conv = new ConvMatrix(3, 3, new int[3, 3] { { 0, 0, 0 }, { -1, 1, 0 }, { 0, 0, 0 } }, 0, 2);
        return ApplyConvMatrix(bitmap, conv);
    }

    // Optimized EdgeDetect using Sobel operator (much faster than producing 8 bitmaps + GetPixel)
    public static Bitmap EdgeDetect(Bitmap bitmap, int threshold = 200)
    {
        int w = bitmap.Width;
        int h = bitmap.Height;

        // Lock bits
        BitmapData srcData = bitmap.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
        int stride = srcData.Stride;
        int byteCount = stride * h;
        byte[] src = new byte[byteCount];
        Marshal.Copy(srcData.Scan0, src, 0, byteCount);

        // convert to grayscale intensity (0..255) stored in double for accumulation
        double[] gray = new double[w * h];
        for (int y = 0; y < h; y++)
        {
            int row = y * stride;
            for (int x = 0; x < w; x++)
            {
                int idx = row + x * 3;
                byte b = src[idx];
                byte g = src[idx + 1];
                byte r = src[idx + 2];
                // standard luminance
                gray[y * w + x] = 0.299 * r + 0.587 * g + 0.114 * b;
            }
        }

        // Sobel kernels
        int[,] gx = new int[3, 3] {
            { -1, 0, 1 },
            { -2, 0, 2 },
            { -1, 0, 1 }
        };
        int[,] gy = new int[3, 3] {
            { -1, -2, -1 },
            {  0,  0,  0 },
            {  1,  2,  1 }
        };

        Bitmap outBmp = new Bitmap(w, h, PixelFormat.Format24bppRgb);
        BitmapData outData = outBmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
        int outStride = outData.Stride;
        byte[] outBytes = new byte[outStride * h];

        for (int y = 1; y < h - 1; y++)
        {
            for (int x = 1; x < w - 1; x++)
            {
                double sumX = 0, sumY = 0;

                for (int ky = -1; ky <= 1; ky++)
                {
                    for (int kx = -1; kx <= 1; kx++)
                    {
                        double val = gray[(y + ky) * w + (x + kx)];
                        sumX += val * gx[kx + 1, ky + 1];
                        sumY += val * gy[kx + 1, ky + 1];
                    }
                }

                double mag = Math.Sqrt(sumX * sumX + sumY * sumY);
                int m = (int)Math.Round(mag);
                m = Math.Max(0, Math.Min(255, m));

                int outIndex = y * outStride + x * 3;
                byte color = (byte)(m > threshold ? 255 : 0);
                outBytes[outIndex] = color;
                outBytes[outIndex + 1] = color;
                outBytes[outIndex + 2] = color;
            }
        }

        // copy borders from original (to avoid black frame)
        for (int y = 0; y < h; y++)
        {
            for (int x = 0; x < w; x++)
            {
                if (y == 0 || y == h - 1 || x == 0 || x == w - 1)
                {
                    int srcIdx = y * stride + x * 3;
                    int dstIdx = y * outStride + x * 3;
                    outBytes[dstIdx] = src[srcIdx];
                    outBytes[dstIdx + 1] = src[srcIdx + 1];
                    outBytes[dstIdx + 2] = src[srcIdx + 2];
                }
            }
        }

        Marshal.Copy(outBytes, 0, outData.Scan0, outBytes.Length);

        bitmap.UnlockBits(srcData);
        outBmp.UnlockBits(outData);

        return outBmp;
    }

    public static Bitmap GaussianBlur(Bitmap bitmap)
    {
        ConvMatrix conv = new ConvMatrix(5, 5, new int[5, 5] {
            { 1, 4, 7, 4, 1 },
            { 4, 16, 26, 16, 4 },
            { 7, 26, 41, 26, 7 },
            { 4, 16, 26, 16, 4 },
            { 1, 4, 7, 4, 1 }
        }, 0, 273);
        return ApplyConvMatrix(bitmap, conv);
    }

    public static Bitmap MeanRemoval(Bitmap bitmap)
    {
        ConvMatrix conv = new ConvMatrix(3, 3, new int[3, 3] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } }, 0, 1);
        return ApplyConvMatrix(bitmap, conv);
    }

    public static Bitmap EmbossLaplascian(Bitmap bitmap)
    {
        ConvMatrix conv = new ConvMatrix(3, 3, new int[3, 3] { { -1, 0, -1 }, { 0, 4, 0 }, { -1, 0, -1 } }, 127, 1);
        return ApplyConvMatrix(bitmap, conv);
    }

    public static Bitmap Dilation(Bitmap bitmap)
    {
        ConvMatrix conv = new ConvMatrix(3, 3, new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } }, 0, 1);
        return ImageProcessing.Thresholding(ApplyConvMatrix(bitmap, conv), 1);
    }

    public static Bitmap Erosion(Bitmap bitmap)
    {
        ConvMatrix conv = new ConvMatrix(3, 3, new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } }, 0, 1);
        return ImageProcessing.Thresholding(ImageProcessing.Complement(ApplyConvMatrix(ImageProcessing.Complement(bitmap), conv)), 1);
    }

    public static Bitmap Smooth(Bitmap bitmap)
    {
        // A simple smoothing kernel (weighted average)
        ConvMatrix conv = new ConvMatrix(3, 3, new int[3, 3]
        {
            { 1, 2, 1 },
            { 2, 4, 2 },
            { 1, 2, 1 }
        }, 0, 16); // factor = sum of weights

        return ApplyConvMatrix(bitmap, conv);
    }
}