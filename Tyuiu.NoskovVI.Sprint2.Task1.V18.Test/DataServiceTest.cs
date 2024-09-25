using Tyuiu.NoskovVI.Sprint2.Task1.V18.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LogicOpTest()
        {
            DataService ds = new DataService();
            int a = 155;
            int b = 696;
            int c = 242;
            int d = 541;
            bool[] wait = { true, true, true, false, true, false };
            CollectionAssert.AreEqual(wait, ds.GetLogicOperations(a, b, c, d));

        }
    }
}