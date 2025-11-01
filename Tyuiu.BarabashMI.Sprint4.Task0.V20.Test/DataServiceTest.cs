using Tyuiu.BarabashMI.Sprint4.Task0.V20.Lib;
namespace Tyuiu.BarabashMI.Sprint4.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int wait = 24576;
            int res = ds.GetMultEvenArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}
