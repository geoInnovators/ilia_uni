using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "-1") break;
                else
                {
                    a.Add( int.Parse(s));
                }
            }
        }

        public static void Matrix()
        {
            int[][] mat = new int[3][];
            mat[0] = new int[5] {0, 3, 2, 10, 4};
            mat[1] = new int[3] { 0, -4, 1 };
            mat[2] = new int[4] { 0, -4, 1, 7 };
            int max = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                for(int j=0;j < mat[i].Length;j++)
                    if (max < mat[i][j])
                        max = mat[i][j];
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }

        public static void FindString()
        {
            string[] mas = new string[5];
            mas[0] = "ded";
            mas[1] = "23432";
            mas[2] = "234";
            mas[3] = "23432";
            mas[4] = "234";
            string s = "2343";
            bool result = false;
            for (int i = 0; i < mas.Length; i++)
            {
                if (s == mas[i])
                {
                    result = true;
                    break;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void FindSum()
        {
            int[] mas;
            mas = new int[10]; // {0,0,0,0,0,0,0,0,0,0}
            mas = new int[5] { 0, 3, -3, 4, 2 };
            int sum = 0;
            foreach (var a in mas)
            {
                sum += a; // sum = sum + a;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
