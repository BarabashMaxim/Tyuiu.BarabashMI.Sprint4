using Tyuiu.BarabashMI.Sprint4.Task1.V18.Lib;
namespace Tyuiu.BarabashMI.Sprint4.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7 };
            int wait = 79;
            int res = ds.Calculate(nums);
            Assert.AreEqual(wait, res);
        }
    }
}
