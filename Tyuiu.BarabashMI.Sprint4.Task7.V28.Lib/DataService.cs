using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BarabashMI.Sprint4.Task7.V28.Lib
{
    public class DataService : ISprint4Task7V28
    {
        public int Calculate(int n, int m, string value)
        {
            int c = 1;
            int[,] matr = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = int.Parse(value.Substring(i * m + j,1));
                    if (matr[i, j] % 2 == 0)
                        c *= matr[i, j];
                }
            }
            return c;
        }
    }
}
