using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Lecture_28_11_2015
{

    class Lecture
    {
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public String CourseName { get; set; }
        public Lecture(DayOfWeek day, TimeSpan startTime, String courseName)
        {
            Day = day;
            StartTime = startTime;
            CourseName = courseName;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Generic();
            Console.ReadKey();
        }

        public static void TestComparable()
        {
            

            Person[] persons = new[]
            {
                new Person("a", "b", DateTime.Today ),
                new Person("a", "b", DateTime.Today ),
                new Person("a", "b", DateTime.Today )
            };
            Array.Sort(persons);

        }

        public static void Generic()
        {
            MyList<string> list = new MyList<string>();

            list.Add("nino");
            list.Add("avto");
            Console.WriteLine(list.Get(10));  // avto
            Console.WriteLine(list.Length);  // avto
        }





        public static String Reverse2(String s)
        {
            char[] c = s.ToCharArray(); // სტრიქონის მასივში გადაყვანა
            Array.Reverse(c);  // მასივის შებრუნებას
            var res = new string(c); // ახალი სტრიქონის მიღება მასივისგან
            return res;  // დაბრუნება ახალი სტრიქონის
        }


        public static String Reverse(String s)
        {
            string res = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                res += s[i];
            }
            return res;
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }






    }
}

//where T : base-class // Base-class constraint
//where T : interface // Interface constraint
//where T : class // Reference-type constraint
//where T : struct // Value-type constraint (excludes Nullable types)
//where T : new() // Parameterless constructor constraint
//where U : T // Naked type constraint
