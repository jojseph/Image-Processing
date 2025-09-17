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
}
