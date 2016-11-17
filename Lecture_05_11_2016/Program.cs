using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;

namespace Lecture_05_11_2016
{
    class Program
    {
        static int GetAge(DateTime dt)
        {
            int age = DateTime.Now.Year - dt.Year - 1;
            Console.WriteLine(dt.DayOfYear);
            Console.WriteLine(DateTime.Now.DayOfYear);
            if(  DateTime.Now.DayOfYear >= dt.DayOfYear )
                age++;
            return age;
        }

        public static void GetTotalDays(DateTime dt)
        {
            Console.WriteLine((DateTime.Today - dt).TotalDays);



        }


        static void Main(string[] args)
        {
            Person pl = new Lecturer("aa", "bb");
            Person ps = new Student("cc", "dd");
            Console.WriteLine(pl.GetFullName());
            Console.WriteLine(ps.GetFullName());
            object ob = pl;
            ob = ps;
            ob = "sdgweg";
            ob = 45;
            Console.ReadLine();
        }
    }
}
