using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_19_11_2016
{
    public delegate int Operations(int a, int b);

    public class OperationMethods
    {
        // ორ რიცხვს შორის მაქსიმალურის პოვნა
        public static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
        // ორ რიცხვს შორის მინიმალურის პოვნა
        public static int GetMin(int a, int b)
        {
            return a < b ? a : b;
        }
        // ორი რიცხვის ჯამი
        public static int GetSum(int a, int b)
        {
            return a + b;
        }
        // ზოგადი ოპერაციები მასივზე op პარამეტრად გადაცემული დელეგატის მიხედვით
        public static int ArrayOperations(int[] mas, Operations op)
        {
            int result = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                result = op(result, mas[i]);
            }
            return result;
        }
    }
}
