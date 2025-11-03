using Tyuiu.BarabashMI.Sprint4.Task5.V3.Lib;
namespace Tyuiu.BarabashMI.Sprint4.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matr =
            {
                {-1,1,-1,1,1 },
                {1,-1,-1,1,-1 },
                {1,1,1,-1,-1 },
                {-1,1,1,-1,-1 },
                {1,-1,-1,-1,1 }
            };
            int[,] wait =
            {
                {0,1,0,1,1 },
                {1,0,0,1,0 },
                {1,1,1,0,0 },
                {0,1,1,0,0 },
                {1,0,0,0,1 }
            };
            int[,] res = ds.Calculate(matr);
            bool m = true;
            for (int i = 0; i < res.GetLength(0); i++)
                for (int j = 0; j < res.GetLength(1); j++)
                    if (wait[i,j] != res[i,j])
                        m = false;
            bool t = true;
            
            Assert.AreEqual(t,m);
        }
    }
}
