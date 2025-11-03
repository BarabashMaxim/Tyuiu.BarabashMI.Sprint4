using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BarabashMI.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            int s = int.MaxValue;
            for (int i = 0; i < array.GetLength(0); i++)
            { 
                s = Math.Min(s, array[i, 0]);
            }
            return s;
        }
    }
}
