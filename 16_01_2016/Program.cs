using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _16_01_2016
{
    delegate string A(); 

    class Program
    {
        static void Main(string[] args)
        {
            A t = goodMorning;
            Print(t);

            t = goodEvening;
            Print(t);

        }

        public static string goodMorning()
        {
            return "good morning";
        }

        public static string goodEvening()
        {
            return "good evening";
        }

        public static void Print(A d)
        {
            Console.WriteLine( d() );
        }



        public static void Divide()
        {
            try
            {
                int a, b;

                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                Console.WriteLine(a/b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("moxda 0-ze gayofa");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("araswori formati");
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message );
            }
        }



        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }




        public static void DistinctWords()
        {
            String s = Console.ReadLine();

            string[] ar = s.Split(' ');

            List<string> l = new List<string>();

            foreach (var word in ar)
            {
                if(  ! l.Contains( word ))
                    l.Add(word);
            }

            Console.WriteLine(l.Count);
            
        }

        public static void DistinctWordsCount()
        {
            String s = Console.ReadLine();

            string[] ar = s.Split(' ');

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in ar)
            {
                if (dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict[word] = 1; // dict.Add(word,1 );
            }

            foreach (var element in dict)
            {
                Console.WriteLine( element.Key + " " + element.Value  );
            }
        }


        public static void DistinctWordsBySet()
        {
            String s = Console.ReadLine();

            string[] ar = s.Split(' ');

            HashSet<string> set = new HashSet<string>();

            foreach (var word in ar)
            {
                if (!set.Contains(word))
                    set.Add(word);
            }

            Console.WriteLine(set.Count);

        }

        
        

    }
}
