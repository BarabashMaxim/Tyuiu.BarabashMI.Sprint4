using Tyuiu.BarabashMI.Sprint4.Task7.V28.Lib;
namespace Tyuiu.BarabashMI.Sprint4.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "623351179845632";
            int wait = 4608;
            int res = ds.Calculate(5, 3, str);
            Assert.AreEqual(wait, res);
        }
    }
}
