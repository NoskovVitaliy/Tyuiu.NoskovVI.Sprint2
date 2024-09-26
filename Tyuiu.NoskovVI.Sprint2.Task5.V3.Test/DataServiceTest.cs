using Tyuiu.NoskovVI.Sprint2.Task5.V3.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DayNameTest()
        {
            DataService ds = new DataService();
            Assert.AreEqual("�����������", ds.FindDayName(1));
            Assert.AreEqual("�������", ds.FindDayName(2));
            Assert.AreEqual("�����", ds.FindDayName(3));
            Assert.AreEqual("�������", ds.FindDayName(4));
            Assert.AreEqual("�������", ds.FindDayName(5));
            Assert.AreEqual("�������", ds.FindDayName(6));
            Assert.AreEqual("�����������", ds.FindDayName(7));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(8);
            });
        }
    }
}