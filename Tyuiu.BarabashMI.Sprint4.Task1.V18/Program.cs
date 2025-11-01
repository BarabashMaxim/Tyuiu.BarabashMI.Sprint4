using Tyuiu.BarabashMI.Sprint4.Task1.V18.Lib;
class Program
{
    static void Main(string[] args)
    { 
        DataService ds = new DataService();
        int p = 0;
        int[] nums = new int[16];
        for (int i = 0; i < nums.Length; i++)
        { 
            string input = Console.ReadLine();
            nums[i] = Convert.ToInt32(input);
        }
        Console.WriteLine(ds.Calculate(nums));
    }
}