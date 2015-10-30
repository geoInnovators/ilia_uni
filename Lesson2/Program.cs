using System;
using System.Collections.Generic;
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

        static void Main(string[] args)
        {
            //TestParse();
            TestPerson();

            Console.ReadKey();
        }


        static void TestParse()
        {
            String s = Console.ReadLine();

            int a ;   //  = int.Parse(s);
            
            bool res = int.TryParse(s, out a );
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
            s = new string('A', 10  );  // AAAAAAAAAA
            char[] mas = new[] {'a', 'v', 't', 'o'};
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
            master.Credits = new[] {100, 50};  // summary credits 150

            Student avto1 = master;
           
            Console.WriteLine(  avto1.Passed()  ); // True
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
            Console.WriteLine(res  );

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
                Console.WriteLine(   person.displayName("en")  );
            }

        }


    }
}
