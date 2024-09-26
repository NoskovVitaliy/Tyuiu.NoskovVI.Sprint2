using Tyuiu.NoskovVI.Sprint2.Task5.V3.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int DayNum;
            Console.WriteLine("Введите номер дня: ");
            DayNum = Convert.ToInt32(Console.ReadLine());

            if (DayNum < 1 || DayNum > 7)
            {
                Console.WriteLine("Введён неправильный день");
            }
            else
            {
                Console.WriteLine($"Это день {ds.FindDayName(DayNum)}");
            }


        }
    }
}
