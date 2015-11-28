using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void print(string s)
        {

            Console.WriteLine(s);
        }

        public static int NumberofLectures(String courseName)
        {
            Console.WriteLine(courseName);
            return 0;
        }

        private static String GetCurrentCourse()
        {
            return null;
        }

        class Lecture
        {
            public DayOfWeek Day { get; set; }
            public TimeSpan StartTime { get; set; }
            public String CourseName { get; set; }

            public Lecture(DayOfWeek day, TimeSpan startTime, String courseName)
            {
                this.Day = day;
                this.StartTime = startTime;
                this.CourseName = courseName;
            }
        }

        class Schedule
        {
            public Lecture[] Lectures { get; set; }

            public Schedule(Lecture[] lectures)
            {
                this.Lectures = lectures;
            }

            public int NumberofLectures(String name)
            {
                return 1;
            }

            public int TotalNumberofLectures(String name)
            {
                return 1;
            }

            public String GetCurrentCourse()
            {
                return "";
            }


        }

        static void Main(string[] args)
        {
            Lecture[] array = new[]
            {
                new Lecture(DayOfWeek.Saturday, TimeSpan.FromHours(9), "C#"),
                new Lecture(DayOfWeek.Saturday, TimeSpan.FromHours(10), "C#"),
                new Lecture(DayOfWeek.Saturday, TimeSpan.FromHours(11), "C#"),
                new Lecture(DayOfWeek.Friday, TimeSpan.FromHours(10), "ASP.NET")
            };
            Schedule sc = new Schedule(array);
            Console.WriteLine(sc.NumberofLectures("C#")); // 3
            Console.WriteLine(sc.NumberofLectures("ASP.NET")); // 1
            Console.WriteLine(sc.GetCurrentCourse()); // C#
        }
        static void TestTimeSpan()
        {

            

            Console.WriteLine (TimeSpan.FromHours(2.5)); // 02:30:00
            Console.WriteLine(TimeSpan.FromSeconds(10)); // 00:00:10


            Console.WriteLine(new TimeSpan(0, 0, 10)); // 00:00:10
            TimeSpan t1 = new TimeSpan(2, 30, 0);  // orsaatinaxevari
            Console.WriteLine(new TimeSpan(2, 30, 0)); // 02:30:00
            //Console.WriteLine(t1 );
            TimeSpan t2 = new TimeSpan(10, 2, 30, 0);  // orsaatinaxevari
            //Console.WriteLine(t2);
            t1 = TimeSpan.FromDays(10);  // ati dge
            //   Console.WriteLine(t1);
            t1 = TimeSpan.FromHours(2);  // ati dge
            //  Console.WriteLine(t1);
            t1 = TimeSpan.FromMinutes(30);  // ati dge
            // Console.WriteLine(t1);
            t1 = TimeSpan.FromSeconds(30);  // ati dge
            // Console.WriteLine(t1);

            //  + , -, 
            t1 = TimeSpan.FromHours(2) + TimeSpan.FromMinutes(30);
            bool check = (TimeSpan.FromHours(2) > TimeSpan.FromMinutes(30));
            t1 = TimeSpan.FromDays(365);
            Console.WriteLine(t1);
            Console.WriteLine("totalis gareshe");
            Console.WriteLine(String.Format("saati : {0}", t1.Hours));
            Console.WriteLine(String.Format("minutes : {0}", t1.Minutes));
            ////////
            Console.WriteLine("total");
            Console.WriteLine(String.Format("saati : {0}", t1.TotalHours));
            Console.WriteLine(String.Format("minutes : {0}", t1.TotalMinutes));
            //  Console.WriteLine(t1);
        }

        static void TestDateTime()
        {


            DateTime tomorrow = DateTime.Now.AddDays(1);
            //Console.WriteLine(tomorrow);
            DateTime yestarday = DateTime.Now.AddDays(-1);
            DateTime ob = DateTime.Now.AddYears(1);
            DateTime m = ob.Add(new TimeSpan(10, 2, 30));
            //Console.WriteLine(DateTime.Now.DayOfWeek); // kviris dge
            //Console.WriteLine(DateTime.Now.Date);  // Date marto aigo tarigi

            DateTime date = DateTime.Now;
            DateTime end = new DateTime(2016, 2, 1);
            while (date < end)
            {
                //Console.WriteLine(date);
                date = date.AddDays(7);
            }
            //  dd   -- dge
            //   d   -- dge ogond 1
            //  MMMM   --  tve
            //  yy


            var culture = CultureInfo.GetCultureInfo("ka-GE");
            string s = DateTime.Now.ToString("d/MMMM/yy", culture.DateTimeFormat);
            Console.WriteLine(s);



        }



        static void TestParse()
        {
            String s = Console.ReadLine();

            int a;   //  = int.Parse(s);

            bool res = int.TryParse(s, out a);
            if (res == true)
            {
                Console.WriteLine(a + 1);
            }
            else
            {
                Console.WriteLine("araswori formati");
            }


        }

        static void TestChar()
        {
            char c = 'ა';
            Console.WriteLine(char.IsLower('A'));   // false
            Console.WriteLine(char.IsLower('a'));   // true
            Console.WriteLine(char.IsUpper('A'));   // true
            Console.WriteLine(char.IsUpper('a'));   // true

        }

        static void TestString()
        {
            string s;
            s = "avto";  // s = "avto"
            s = new string('A', 10);  // AAAAAAAAAA
            char[] mas = new[] { 'a', 'v', 't', 'o' };
            s = "avto"; // s = "avto"

            char a = s[3];   //  a = 'o'

            s = "avto rukhadze";
            bool o = s.Contains("rukhadze");  // true

            bool c = s.Contains('l');  // false
            bool d = s.Contains("l");  // false

            o = s.StartsWith("avto");  // true
            o = s.StartsWith("rukhadze");  // false

            o = s.EndsWith("rukhadze");  // true
            o = s.EndsWith("avto");  // false
            s = "avto rukhadze rukhadze";
            int index = s.IndexOf("rukhadze"); // index = 5
            int endIndex = index + "rukhadze".Length;
            index = s.LastIndexOf("rukhadze");  // index = 13
            index = s.IndexOf("giorgi"); // index = -1;

            s = "avto";
            // concat
            string s2 = s + " giorgi";  // s2 = "avto giorgi"
            // substring
            string s3 = s2.Substring(5, 6); // giorgi
            string s4 = s2.Substring(5); // giorgi
            string s5 = "avtogiorgi".Insert(4, " ");
            string s6 = "avto giorgi".Remove(4);  // avto
            string s7 = "avto giorgi".Remove(4, 1);  // avtogiorgi


            Console.WriteLine(s7);
        }


        public static void TestBigInteger()
        {
            BigInteger first = new BigInteger("100000000000000000000000000000003453453453");
            BigInteger secod = new BigInteger("100000000000000000000000000000003453453453");
            BigInteger jami = BigInteger.Add(first, secod);

            Console.WriteLine(jami.StringValue);

        }

        public static void TestStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 50; i++) sb.Append(i + ",");

            Console.WriteLine(sb.ToString());  //

            String s2 = "";
            for (int i = 0; i < 50; i++)
                s2 = s2 + i + ",";
            Console.WriteLine(s2); //  


        }

        public static void TestVirtualMethod()
        {
            // giorgi
            Student giorgi = new Bachelor();
            giorgi.Name = "giorgi";
            giorgi.LastName = "giorgadze";
            // avto
            Master master = new Master();
            master.Name = "avto";
            master.LastName = "rukhadze";
            master.Credits = new[] { 100, 50 };  // summary credits 150

            Student avto1 = master;

            Console.WriteLine(avto1.Passed()); // True
            Master avto2 = master;
            Console.WriteLine(avto2.Passed()); // True

            Student[] dataBase = new Student[]
            {
                new Master() {Credits = new int[] {100, 150}, Name = "avto"},
                new Bachelor() {Credits = new int[] {200, 50}, Name = "giorgi"},
                new Master() {Credits = new int[] {100, 150}, Name = "avto"},
                new Bachelor() {Credits = new int[] {200, 50}, Name = "giorgi"},
                new Master() {Credits = new int[] {100, 150}, Name = "avto"},
                new Bachelor() {Credits = new int[] {200, 50}, Name = "giorgi"},
                new Master() {Credits = new int[] {100, 150}, Name = "avto"},
                new Bachelor() {Credits = new int[] {200, 50}, Name = "giorgi"},
            };



            int res = 0;
            foreach (var student in dataBase)
            {
                if (student.Passed()) res++;
            }
            Console.WriteLine(res);

        }

        public static void TestPerson()
        {
            Person[] dataBase = new Person[]
            {
                new Master() {Credits = new int[] {100, 150}, Name = "avto", LastName = "gvari"},
                new Bachelor() {Credits = new int[] {200, 50}, Name = "giorgi", LastName = "gvari"},
                new Master() {Credits = new int[] {100, 150}, Name = "avto", LastName = "gvari"},
                new Bachelor() {Credits = new int[] {200, 50}, Name = "giorgi", LastName = "gvari"},
                new Master() {Credits = new int[] {100, 150}, Name = "avto", LastName = "gvari"},
                new Bachelor() {Credits = new int[] {200, 50}, Name = "giorgi", LastName = "gvari"},
                new Master() {Credits = new int[] {100, 150}, Name = "avto", LastName = "gvari"},
                new Bachelor() {Credits = new int[] {200, 50}, Name = "giorgi", LastName = "gvari"},
                
                new Lector() { Name = "giorgi", LastName = "gvari"},

            };


            foreach (var person in dataBase)
            {
                Console.WriteLine(person.displayName("en"));
            }

        }


    }
}