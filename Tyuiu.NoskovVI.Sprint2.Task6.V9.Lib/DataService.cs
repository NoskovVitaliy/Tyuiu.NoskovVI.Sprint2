using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NoskovVI.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            if ((m % 2 != 0 && n == 30) || (m % 2 == 0 && n == 31))
            {
                m++;
            }
            switch (m)
            {
                case 1: return $"Завтра {n + 1} Января";
                case 2: return $"Завтра {n%30 + 1} Февраля";
                case 3: return $"Завтра {n%31 + 1} Марта";
                case 4: return $"Завтра {n%30 + 1} Апреля";
                case 5: return $"Завтра {n%31 + 1} Мая";
                case 6: return $"Завтра {n%30 + 1} Июня";
                case 7: return $"Завтра {n%31 + 1} Июля";
                case 8: return $"Завтра {n%30 + 1} Августа";
                case 9: return $"Завтра {n%31 + 1} Сентября";
                case 10: return $"Завтра {n%30 + 1} Октября";
                case 11: return $"Завтра {n%31 + 1} Ноября";
                case 12: return $"Завтра {n%30 + 1} Декабря";
                default: throw new ArgumentException("Если вы попробовали ввести 31 Декабря, то такая функция недоступна.");
            }
        }
    }
}
