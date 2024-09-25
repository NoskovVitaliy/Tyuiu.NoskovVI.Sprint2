using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NoskovVI.Sprint2.Task2.V26.Lib
{
    public class DataService : ISprint2Task2V26
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            return (x >= 3 && x <= 5 && y >= 3 && y <= 7) || (x >= 6 && x <= 9 && y >= 5 && y <= 11) || (x >= 3 && x <= 5 && y == 11) || (x == 10 && y >= 5 && y <= 8) || (x >= 11 && x <= 13 && y >= 6 && y <= 8) || (x >= 9 && x <= 10 && y >= 3 && y <= 4) || (x >= 11 && x <= 12 && y == 3) || (x >= 9 && x <= 10 && y == 13) || (x >= 7 && x <= 9 && y == 12) || (x >= 10 && x <= 12 && y >= 11 && y <= 12); 
        }
    }
}
