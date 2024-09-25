using Tyuiu.NoskovVI.Sprint2.Task2.V26.Lib;

namespace Tyuiu.NoskovVI.Sprint2.Task2.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и*");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите абциссу точки: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите ординату точки: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (ds.CheckDotInShadedArea(x, y) == true)
                Console.WriteLine("Точка находится в закрашенной области");
            else
                Console.WriteLine("Точка не находится в закрашенной области");
        }
    }
}
