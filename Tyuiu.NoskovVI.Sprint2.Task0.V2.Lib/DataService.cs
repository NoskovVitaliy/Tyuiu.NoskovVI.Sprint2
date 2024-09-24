﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NoskovVI.Sprint2.Task0.V2.Lib
{
    public class DataService : ISprint2Task0V2
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            // x = 123 y = 123

            result[0] = x != y;
            result[1] = x == y;
            result[2] = x > y;
            result[3] = x - y == 0;
            result[4] = x < y;
            result[5] = x + y == 246;
            return result;
        }
    }
}
