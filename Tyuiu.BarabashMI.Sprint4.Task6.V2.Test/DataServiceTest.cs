using Tyuiu.BarabashMI.Sprint4.Task6.V2.Lib;
namespace Tyuiu.BarabashMI.Sprint4.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] ar = { "Белый", "Чёрный", "Зелёный", "Синий", "Красный", "Жёлтый", "Фиолетовый" };
            string[] wait = { "Чёрный", "Зелёный", "Красный", "Жёлтый", "Фиолетовый"};
            string[] ress = ds.Calculate(ar);
            bool t = true;
            if (ress.Length == wait.Length)
            {
                for (int i = 0; i < wait.Length; i++)
                { 
                    if (ress[i] != wait[i])
                        t = false;
                }
            }
            Assert.IsTrue(t);
        }
    }
}
