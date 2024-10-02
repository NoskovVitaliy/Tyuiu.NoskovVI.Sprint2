using Tyuiu.NoskovVI.Sprint2.Task7.V1.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ShadedDotTest()
        {
            DataService ds = new DataService();
            double x, y;
            x = 0.5;
            y = 0.6;
            bool wait = true;
            Assert.AreEqual(wait,ds.CheckDotInShadedArea(x, y));
        }
    }
}