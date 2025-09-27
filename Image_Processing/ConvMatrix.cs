public class ConvMatrix
{
    public int n, m;
    public int[,] matrix;
    public int offset, factor;

    public ConvMatrix(int n, int m, int[,] matrix, int offset, int factor)
    {
        this.n = n;
        this.m = m;
        this.matrix = matrix;
        this.offset = offset;
        this.factor = factor;
    }
    public ConvMatrix()
    {
        n = 3;
        m = 3;
        matrix = new int[3, 3];
        offset = 0;
        factor = 1;
    }

    public void SetAll(int value)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = value;
            }
        }
    }



}
