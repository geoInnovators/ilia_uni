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
            TestString();

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


    }
}
