using Tyuiu.BarabashMI.Sprint4.Task4.V5.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int n,m;
        n = Convert.ToInt32(Console.ReadLine());
        m = Convert.ToInt32(Console.ReadLine());
        int[,] matr = new int[n,m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine(ds.Calculate(matr));
    }
}