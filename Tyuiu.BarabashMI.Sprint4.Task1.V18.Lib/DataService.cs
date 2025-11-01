using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BarabashMI.Sprint4.Task1.V18.Lib
{
    public class DataService : ISprint4Task1V18
    {
        public int Calculate(int[] array)
        {
            int p = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    p += array[i];
            }
            return p;
        }
    }
}
