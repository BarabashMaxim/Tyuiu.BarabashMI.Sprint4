using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BarabashMI.Sprint4.Task0.V20.Lib
{
    public class DataService : ISprint4Task0V20
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int[] nums = array;
            int p = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    p *= nums[i];
            }
            return p;
        }
    }
}
