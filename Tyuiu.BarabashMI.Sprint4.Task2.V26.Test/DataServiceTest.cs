using Tyuiu.BarabashMI.Sprint4.Task2.V26.Lib;
namespace Tyuiu.BarabashMI.Sprint4.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = new int[14] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int wait = 1;
            int res = ds.Calculate(nums);
            Assert.AreEqual(wait, res);

        }
    }
}
