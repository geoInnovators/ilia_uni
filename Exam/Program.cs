using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( GetCharCount("aabaaaba", 'a')); 
            Console.WriteLine(GetCharByMaxCount("a a b   vvvv   vvvba")); 
            Console.WriteLine(GetCharByMaxCount2("a a b   vvvv   vvvba")); 
            Console.WriteLine(GetCharByMaxCount3("a a b   vvvv   vvvba")); 
            Circle c = new Circle(0, 0, 5 * 158777);
            Console.WriteLine(c.IsPointInside(new Point(3 * 158777, 4 * 158777)));
        }

        public static int GetCharCount(string s, char c)
        {
            int result = 0;
            foreach (var simbolo in s)
            {
                if (simbolo == c)
                    result++;
            }
            return result;
        }

        public static char GetCharByMaxCount(string s)
        {
            Dictionary<char,int> dict = new Dictionary<char, int>();
            foreach (var simbolo in s)
            {
                if (!dict.ContainsKey(simbolo))
                    dict.Add(simbolo, 1);
                else
                    dict[simbolo]++;
            }
            int maxCount = 0;
            char result = 'a';
            foreach (var entry in dict)
            {
                if (entry.Value > maxCount)
                {
                    result = entry.Key;
                    maxCount = entry.Value;
                }
            }
            return result;
        }
        public static char GetCharByMaxCount2(string s)
        {
            int[] count = new int[char.MaxValue +1];
            int maxCount = 0;
            char result = 'a';
            foreach (var simbolo in s)
            {
                count[simbolo]++;
                if (count[simbolo] > maxCount)
                {
                    result = simbolo;
                    maxCount = count[simbolo];
                }
            }
            return result;
        }

        public static char GetCharByMaxCount3(string s)
        {
            int[] count = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        count[i]++;
                }
            }
            int maxCount = 0;
            char result = 'a';
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > maxCount)
                {
                    result = s[i];
                    maxCount = count[i];
                }                
            }
            return result;
        }
    }

    class Point
    {
        public int X;
        public int Y;
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
    }

    class Circle
    {
        public int R;
        public Point C;

        public Circle(int x, int y, int r)
        {
            C = new Point(x,y);
            R = r;
        }
        public bool IsPointInside(Point p)
        {
            return (C.X - p.X)*(C.X - p.X) + (C.Y - p.Y)*(C.Y - p.Y) < R*R;
        }
    }
}
