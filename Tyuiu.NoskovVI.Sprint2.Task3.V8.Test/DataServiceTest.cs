using Tyuiu.NoskovVI.Sprint2.Task3.V8.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 1;
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        [TestMethod]
        public void ValidCalc2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.75;
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        [TestMethod]
        public void ValidCalc3()
        {
            DataService ds = new DataService();
            double x = -1;
            double wait = 0.25;
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        [TestMethod]
        public void ValidCalc4()
        {
            DataService ds = new DataService();
            double x = -13;
            double wait = -142.615;
            Assert.AreEqual(wait, ds.Calculate(x));
        }
    }
}