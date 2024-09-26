using Tyuiu.NoskovVI.Sprint2.Task4.V1.Lib;
namespace Tyuiu.NoskovVI.Sprint2.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции        *");
            Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит          *");
            Console.WriteLine("* значение переменных x,y с клавиатуры, если x<y, то z = x+3/y, иначе     *");
            Console.WriteLine("* (x+1/x-2)                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение Х: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Z = " + ds.Calculate(x,y));
        }
    }
}
