using Tyuiu.NoskovVI.Sprint2.Task2.V26.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ShadedAreaDotTest()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 7;
            bool wait = true;
            Assert.AreEqual(wait, ds.CheckDotInShadedArea(x, y));
        }
    }
}