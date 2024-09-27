using Tyuiu.NoskovVI.Sprint2.Task6.V9.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void NextDayDateTest()
        {
            DataService ds = new DataService();
            Assert.AreEqual("������ 2 ������", ds.FindDateOfNextDay(1, 1));
            Assert.AreEqual("������ 1 �����", ds.FindDateOfNextDay(2, 31));
            Assert.AreEqual("������ 1 ������", ds.FindDateOfNextDay(3, 30));
            Assert.AreEqual("������ 1 ���", ds.FindDateOfNextDay(4, 31));
            Assert.AreEqual("������ 10 ���", ds.FindDateOfNextDay(5, 9));
            Assert.AreEqual("������ 1 ����", ds.FindDateOfNextDay(6, 31));
            Assert.AreEqual("������ 2 ����", ds.FindDateOfNextDay(7, 1));
            Assert.AreEqual("������ 1 ��������", ds.FindDateOfNextDay(8, 31));
            Assert.AreEqual("������ 1 �������", ds.FindDateOfNextDay(9, 30));
            Assert.AreEqual("������ 16 �������", ds.FindDateOfNextDay(10, 15));
            Assert.AreEqual("������ 8 ������", ds.FindDateOfNextDay(11, 7));
            Assert.AreEqual("������ 2 �������", ds.FindDateOfNextDay(12, 1));
        }
    }
}