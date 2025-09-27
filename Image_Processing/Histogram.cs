using System;
using System.Drawing;
using System.Linq;

public class Histogram
{
    public Histogram()
    {
    }

    private static int[] calculateHistogram(Bitmap bitmap)
    {
        int[] hist = new int[256];
        for (int i = 0; i < bitmap.Width; i++)
        {
            for (int j = 0; j < bitmap.Height; j++)
            {
                Color pixel = bitmap.GetPixel(i, j);
                int avg = (pixel.R + pixel.G + pixel.B) / 3;
                hist[avg]++;
            }
        }
        return hist;
    }

    public static Bitmap DrawHistogram(Bitmap bitmap, Size targetSize)
    {
        Bitmap processed = new Bitmap(targetSize.Width, targetSize.Height);
        int[] hist = calculateHistogram(bitmap);

        int max = hist.Max();
        if (max == 0) max = 1; 

        double scale = (double)targetSize.Height / max;
        double barWidth = (double)targetSize.Width / 256;

        using (Graphics g = Graphics.FromImage(processed))
        {
            g.Clear(Color.White);

            using (Brush brush = new SolidBrush(Color.Black))
            {
                for (int i = 0; i < hist.Length; i++)
                {
                    int barHeight = (int)(hist[i] * scale);
                    if (barHeight > 0)
                    {
                        float x = (float)(i * barWidth);
                        float y = targetSize.Height - barHeight;
                        float width = Math.Max(1, (float)barWidth);

                        g.FillRectangle(brush, x, y, width, barHeight);
                    }
                }
            }
        }
        return processed;
    }
}