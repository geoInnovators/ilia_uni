using System;
using testNamespace;
namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            Test(out a);
            Console.WriteLine(a); // ras dabechdavs
            Console.ReadLine();
        }

        static void Test(out int a)
        {
            a = 0;
            a = a + 1;
        }
    }
}
