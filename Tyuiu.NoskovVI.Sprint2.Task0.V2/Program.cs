using Tyuiu.NoskovVI.Sprint2.Task0.V2.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 123;
            int y = 123;
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)*");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую                   *");
            Console.WriteLine("* последовательность(массив): (False, True, False, True, False, True)     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* X = 123, y = 123                                                        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] Answer = ds.GetCompareOperations(x, y);
            for (int i = 0; i < Answer.Length; i++)
            {
                Console.Write(Answer[i] + ", ");
            }

        }
    }
}
