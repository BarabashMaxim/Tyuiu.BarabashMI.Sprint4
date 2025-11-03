using System.Numerics;
using Tyuiu.BarabashMI.Sprint4.Task3.V20.Lib;
class Program
{
    static void Main(string[] args)
    { 
        DataService ds = new DataService();
        int[,] matr =
            {
                {8,7,7,8,5 },
                {4,3,5,3,6 },
                {5,3,8,6,3 },
                {6,3,8,5,4 },
                {3,6,8,3,4 }
            };
        Console.WriteLine(ds.Calculate(matr));
    }
}