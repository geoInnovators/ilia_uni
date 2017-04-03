using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_DateTime
{
    class Program
    {
        static void TimeSpanExamples()
        {
            TimeSpan Ati = TimeSpan.FromHours(10); //   new TimeSpan(10, 0, 0);
            TimeSpan wami = TimeSpan.FromSeconds(1);  //   new TimeSpan(0, 0, 1);
            TimeSpan dro = Ati - wami; // 09:59:59
            Console.WriteLine(dro);

            Console.WriteLine(dro.Days); // 0
            Console.WriteLine(dro.Hours); // 9
            Console.WriteLine(dro.Minutes); // 59
            Console.WriteLine(dro.Seconds); // 59

            Console.WriteLine(dro.TotalDays);
            Console.WriteLine(dro.TotalHours);
            Console.WriteLine(dro.TotalMinutes);
            Console.WriteLine(dro.TotalSeconds);
            Console.ReadLine();

            TimeSpan t = new TimeSpan(2, 30, 0); // 02:30:00
            Console.WriteLine(t);
            TimeSpan t10Wami = new TimeSpan(0, 0, 10); // 00:0:10
            TimeSpan tmilisecond = new TimeSpan(0, 0, 0, 10, 23);
            Console.WriteLine(tmilisecond);
            Console.WriteLine(t > t10Wami); // true
            Console.WriteLine(t10Wami > tmilisecond); // false
            Console.WriteLine(t10Wami + tmilisecond);
            Console.WriteLine(tmilisecond - t10Wami);
        }

        static void DateTimeExamples()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MMM/yyyy"));
            Console.ReadLine();

            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine(DateTime.MaxValue);
            Console.ReadLine();
            DateTime dt1 = new DateTime(2017, 03, 28); //  28.03.2017
            TimeSpan t = TimeSpan.FromHours(5);  // 05:00:00
            DateTime result = dt1 + t; //  28.03.2017 05:00 
            Console.WriteLine(result);
            Console.ReadLine();

            DateTime dt = new DateTime(2017, 11, 25); // 25-noemberi-2017
            Console.WriteLine(DateTime.Now); // tarigi + dro
            Console.WriteLine(DateTime.Today); // tarigi
            Console.WriteLine(DateTime.UtcNow); // 
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            DateTimeExamples();

        }
    }
}
