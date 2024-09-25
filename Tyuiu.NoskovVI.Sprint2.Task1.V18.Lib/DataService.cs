using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NoskovVI.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            //a = 155   b = 696 c = 242 d = 541
            result[0] = b>d && c>a;
            result[1] = b < d ^ d > a;
            result[2] = b > a || c > a;
            result[3] = !(a != b);
            result[4] = b == a + d;
            result[5] = !(result[0]);
            return result;

        }
    }
}
