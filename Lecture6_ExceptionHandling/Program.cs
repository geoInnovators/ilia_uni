using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            MyException();
            DivideNumbers();

            try
            {
                var s = Console.ReadLine();
                int val = int.Parse(s); // convertacia striqonitan integershi
                int a, b;
                a = 5;
                b = 0;
                Console.WriteLine(a / b); // runtime error
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    Console.WriteLine("gtxovt sheiyvanot ricxvi!");
                }
                else if (ex is DivideByZeroException)
                {
                    Console.WriteLine("moxda 0ze gayofa!");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }

        static void ParseExample()
        {
            string s = "c";
            var a = int.Parse(s); // throws exception
            int b;
            bool t = int.TryParse(s, out b); // false
        }

        static void DivideNumbers()
        {
            try
            {
                string s = Console.ReadLine(); //  "45 23 34 34 23"  split -> ["45","23","45","34","23"]
                var mas = s.Split();
                int a = int.Parse(mas[0]);
                int b = int.Parse(mas[1]);
                Console.WriteLine((decimal) a/b); // a=5, b=10;  0.5/  0
            }
            catch (FormatException ex)
            {
                Console.WriteLine("sheiyvane swori ricxvi");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("gamyofi ar unda iyos 0-is toli");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }

        static void MyException()
        {
            try
            {
                string name = Console.ReadLine();
                string lastname = Console.ReadLine();
                if (name == "" || lastname == "")
                {
                    var error = new MyException("gtxovt sheiyvanot saxeli da gvari");
                    throw error;
                }
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // valogirebt
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class MyException : Exception
    {
        public MyException(string exception)  : base(exception)
        {
            
        }
    }
}
