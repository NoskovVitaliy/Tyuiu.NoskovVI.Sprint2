using Tyuiu.NoskovVI.Sprint2.Task0.V2.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetCompareTest()
        {
            DataService ds = new DataService();
            int x = 123;
            int y = 123;
            bool[] wait = { false, true, false, true, false, true };
            CollectionAssert.AreEqual(wait, ds.GetCompareOperations(x, y));
        }
    }
}