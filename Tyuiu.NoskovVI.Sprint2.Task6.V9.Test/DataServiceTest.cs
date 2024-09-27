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
            Assert.AreEqual("Завтра 2 Января", ds.FindDateOfNextDay(1, 1));
            Assert.AreEqual("Завтра 1 Марта", ds.FindDateOfNextDay(2, 31));
            Assert.AreEqual("Завтра 1 Апреля", ds.FindDateOfNextDay(3, 30));
            Assert.AreEqual("Завтра 1 Мая", ds.FindDateOfNextDay(4, 31));
            Assert.AreEqual("Завтра 10 Мая", ds.FindDateOfNextDay(5, 9));
            Assert.AreEqual("Завтра 1 Июля", ds.FindDateOfNextDay(6, 31));
            Assert.AreEqual("Завтра 2 Июля", ds.FindDateOfNextDay(7, 1));
            Assert.AreEqual("Завтра 1 Сентября", ds.FindDateOfNextDay(8, 31));
            Assert.AreEqual("Завтра 1 Октября", ds.FindDateOfNextDay(9, 30));
            Assert.AreEqual("Завтра 16 Октября", ds.FindDateOfNextDay(10, 15));
            Assert.AreEqual("Завтра 8 Ноября", ds.FindDateOfNextDay(11, 7));
            Assert.AreEqual("Завтра 2 Декабря", ds.FindDateOfNextDay(12, 1));
        }
    }
}