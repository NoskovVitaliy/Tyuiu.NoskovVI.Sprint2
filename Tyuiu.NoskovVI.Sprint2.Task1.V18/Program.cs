using Tyuiu.NoskovVI.Sprint2.Task1.V18.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 155;
            int b = 696;
            int c = 242;
            int d = 541;
            Console.Title = "Спринт #2 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)*");
            Console.WriteLine("* логических операций (|, &, ||, &&, !, ^,                                *");
            Console.WriteLine("* последовательность операций не должна нарушаться),а также               *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
            Console.WriteLine("* (массив): (True, True, True, False, True, False)                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 155, b = 696, c = 242, d = 541                                      *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] Answer = ds.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < Answer.Length; i++)
            {
                Console.Write(Answer[i] + ", ");
            }
        }
    }
}
