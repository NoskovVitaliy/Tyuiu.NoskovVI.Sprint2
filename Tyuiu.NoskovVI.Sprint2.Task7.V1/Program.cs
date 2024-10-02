using Tyuiu.NoskovVI.Sprint2.Task7.V1.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых результатов по спринту              *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X,Y в заштрихованной области.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите Y точки: ");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите X точки: ");
            x = double.Parse(Console.ReadLine());

            if (ds.CheckDotInShadedArea(x, y)) Console.WriteLine("Точка находится в закрашенной области");
            else Console.WriteLine("Точка не находится в закрашенной области");
        }
    }
}
