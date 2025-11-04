using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BarabashMI.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            int i = 0;
            int c = 0;
            foreach (string item in array)
            {
                if (item.Length > 5)
                {
                    c++;
                }
            }
            string[] res = new string[c];
            foreach (string item in array)
            {
                if (item.Length > 5)
                {
                    res[i] = item;
                    i++;
                }
            }
            return res;
        }
    }
}
