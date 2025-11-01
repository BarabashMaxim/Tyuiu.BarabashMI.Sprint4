using Tyuiu.BarabashMI.Sprint4.Task2.V26.Lib;
class Program
{
    static void Main(string[] args)
    { 
        DataService ds = new DataService();
        int p = 1;
        int[] nums = new int[12];
        for (int i = 0; i < nums.Length; i++)
        { 
            string input = Console.ReadLine();
            nums[i] = Convert.ToInt32(input);
        }
        Console.WriteLine(ds.Calculate(nums));2
    }
}