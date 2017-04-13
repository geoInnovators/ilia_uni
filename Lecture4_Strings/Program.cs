using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            DefinePalindrome();
            Console.ReadLine();
            GetWordsCount();


            Manipulation();

            string s = Console.ReadLine();
            char result = GetResult(s); // gamozaxeba funqciis



            char x = 'a';  // ertmagi charis agmnishvneli
            string a = "dded"; // ormagi string-is agmnishvneli
            string carieli = ""; // 0
            Console.WriteLine(a.Length); // Length tviseba agnishnavs striqonis sigrzes

            string c = a + "aa"; // c = "ddedaa";
            // chamovuarot striqonis yvela simbolos da davbechdot
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);
            // foreach ciklit navigacia
            foreach(char i in a)
            {
                Console.WriteLine(i);
            }

            
        }

        public static char GetResult(string s)
        {
            // s = "aaabbcc";
            char result = s[0];
            int[] counter = new int[100]; // 0,0,0,0,0,0,0,0,0,0,0
            foreach (char c in s)
            {
                counter[c]++;
            }
            int tmpMax = 0;
            for(int i=0;i < 100; i++)
            {
                if(counter[i] > tmpMax)
                {
                    tmpMax = counter[i];
                    result = (char)i;
                }
            }
            return result; // simbolo romelic gvxvdeba yvelaze metjer
        }

        public static void Zebna()
        {
            string a = "aaa  bbb";
            string b = "bb";
            Console.WriteLine(a.Contains(b));  // true
            Console.WriteLine(a.StartsWith(b));  // false
            Console.WriteLine(a.EndsWith(b));  // true
            Console.WriteLine(a.IndexOf("bbc"));  // -1
            Console.ReadLine();
        }

        public static void Manipulation()
        {
            string s = "giorgi revazishvili";
            string sub = s.Substring(2, 10);  
            Console.WriteLine(sub);
            Console.WriteLine(s.Substring(2));
            string s1 = "giorgirevazishvili";
            Console.WriteLine(s1.Insert(5, " ")); // giorgi revazishvili
            Console.WriteLine(s.Remove(5, 2)); // giorgievazishvili

            string words = "aa bb cc eee de";  // { "aa", "bb", "cc", "eee", "de" }
            // striqonebis masivi
            string[] max=   words.Split();  // { "aa", "bb", "cc", "eee", "de" }
        }

        public static void GetWordsCount()
        {
            string s = Console.ReadLine();
            Console.WriteLine(s.Split().Length); // sityvebis raodenoba
        }

        public static void DefinePalindrome()
        {
            string s = Console.ReadLine(); // wakitxva
            // aabaa
            // i=0,j=4
            // i=1,j=3
            // i=2,j=2
            /// abba
            /// i=0,j-3
            /// i=1,j=2
            for(int i=0,j = s.Length-1; i < j; i++, j--)
            {
                if( s[i] != s[j])
                {
                    Console.WriteLine(false);
                    return;
                }
            }
            Console.WriteLine(true);
        }

        // aaabaaa 
    }
}
