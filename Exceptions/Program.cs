using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            TestList();
            Console.ReadKey();
        }

        static void TestException()
        {
            try
            {
                int a = 5;
                int b;
                b = int.Parse(Console.ReadLine());
                int c = a / b; // throw  e
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("moxda 0-ze gayofa");
            }
            catch (FormatException e)
            {
                Console.WriteLine("moxda araswori formatis sheyvana");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void TestList()
        {
            try
            {
                MyList<int> l = new MyList<int>();
                l.Add(5);
                l.Add(9);
                l.Add(10);
                Console.WriteLine(l.Get(23));
            }
            catch (ProgramException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
            }
        }


    }
}
