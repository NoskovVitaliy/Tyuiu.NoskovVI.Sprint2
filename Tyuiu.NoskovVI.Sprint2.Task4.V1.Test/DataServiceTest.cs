using Tyuiu.NoskovVI.Sprint2.Task4.V1.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 2;
            Assert.AreEqual(wait, ds.Calculate(x, y));
        }

        [TestMethod]
        public void CalcTest2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double wait = 4;
            Assert.AreEqual(wait,ds.Calculate(x, y));
        }
    }
}