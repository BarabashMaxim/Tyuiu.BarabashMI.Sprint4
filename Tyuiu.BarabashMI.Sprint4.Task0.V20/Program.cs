using Tyuiu.BarabashMI.Sprint4.Task0.V20.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[] nums = new int[10];
        for (int i = 0; i < nums.Length; i++)
        { 
            string input = Console.ReadLine();
            nums[i] = Convert.ToInt32(input);
        }
        Console.WriteLine(ds.GetMultEvenArrEl(nums));
    }
}