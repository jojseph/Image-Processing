public class Historgram
{
    public Historgram()
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
        double scale = (double)targetSize.Height / max;

        using (Graphics g = Graphics.FromImage(processed))
        {
            g.Clear(Color.White);
            for (int i = 0; i < hist.Length; i++)
            {
                int barHeight = (int)(hist[i] * scale);
                g.DrawLine(Pens.Black, i * targetSize.Width / 256, targetSize.Height - 1,
                    i * targetSize.Width / 256, targetSize.Height - barHeight);
            }
        }
        return processed;
    }
}