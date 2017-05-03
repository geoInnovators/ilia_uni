using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7_Generics
{
    delegate int Operation(int a, int b);

    class Program
    {
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }

        static void Main(string[] args)
        {
            Operation c;
            c = Max;
            Console.WriteLine(c(5,7)); // 7
            c = Min;
            Console.WriteLine(c(5, 7)); // 5

            int a = 5, b = 7;
            Swap(ref a, ref b);
            Console.WriteLine(a );  // 7
            Console.WriteLine(b);  // 5

            decimal x = 0.5m, y = 0.7m;
            Swap(ref x, ref y);
            Console.ReadLine();

            Stack<int> s = new Stack<int>();
            s.Push(4);s.Push(7);s.Push(10);
            s.Pop();s.Push(20);
            Console.WriteLine(s.Pop()); // 

            Stack<decimal> d = new Stack<decimal>();
            d.Push(4.3m);
            Console.WriteLine(d.Pop()); // 
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }

    class Stack<T>
    {
        private T[] mas = new T[100];
        private int Index = 0;
        public void Push(T a)
        {
            mas[Index++] = a;
        }

        public T Pop()
        {
            return mas[--Index];
        }
    }
}
