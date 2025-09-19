public class ImageProcessing
{
    ImageProcessing()
    {
    }
    public static int average(Color pixel)
    {
        return (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
    }

    public static Bitmap Run(Bitmap bitmap, Func<Bitmap, int, int, Color> func)
    {
        Bitmap processed = new Bitmap(bitmap.Width, bitmap.Height);
        for (int y = 0; y < bitmap.Height; y++)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                processed.SetPixel(x, y, func(bitmap, x, y));
            }
        }
        return processed;
    }
    public static Bitmap Duplicate(Bitmap bitmap)
    {
        return Run(bitmap, (bitmap, x, y) => bitmap.GetPixel(x, y));
    }
    public static Bitmap Grayscale(Bitmap bitmap)
    {
        return Run(bitmap, (bitmap, x, y) =>
        {
            Color original = bitmap.GetPixel(x, y);
            int gray = average(original);
            return Color.FromArgb(gray, gray, gray);
        });
    }
    public static Bitmap Invert(Bitmap bitmap)
    {
        return Run(bitmap, (bitmap, x, y) =>
        {
            Color original = bitmap.GetPixel(x, y);
            return Color.FromArgb(255 - original.R, 255 - original.G, 255 - original.B);
        });
    }
    public static Bitmap Sepia(Bitmap bitmap)
    {
        return Run(bitmap, (bitmap, x, y) =>
        {
            Color original = bitmap.GetPixel(x, y);
            int gray = average(original);
            int r = Math.Min(255, (int)(gray * 1.2));
            int g = Math.Min(255, (int)(gray * 1.0));
            int b = Math.Min(255, (int)(gray * 0.8));
            return Color.FromArgb(r, g, b);
        });
    }
    private static Bitmap ResizeImage(Bitmap a, Bitmap b)
    {
        Bitmap resizedImage = new Bitmap(b.Width, b.Height);

        using (Graphics g = Graphics.FromImage(resizedImage))
        {
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            g.DrawImage(a, new Rectangle(0, 0, b.Width, b.Height));
        }

        return resizedImage;
    }

    public static Bitmap Subtract(Bitmap imageA, Bitmap imageB, Color subColor)
    {
        if (imageA == null || imageB == null) { return null; }

        Bitmap a = ResizeImage(imageA, imageB);

        int sub = (subColor.R + subColor.G + subColor.B) / 3;
        int threshold = 10;

        Bitmap subtractRes = new Bitmap(a.Width, a.Height);

        for (int i = 0; i < a.Width; i++)
        {
            for (int j = 0; j < a.Height; j++)
            {
                Color front = a.GetPixel(i, j);
                Color back = imageB.GetPixel(i, j);
                int curr = (front.R + front.G + front.B) / 3;
                subtractRes.SetPixel(i, j, Math.Abs(curr - sub) <= threshold ? back : front);
            }
        }

        return subtractRes;
    }
}
