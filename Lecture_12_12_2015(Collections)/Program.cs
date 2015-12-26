using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12_12_2015_Collections_
{
    class MyCollection : IEnumerable
    {
        private DateTime _minDate;
        private DateTime _maxDate;

        public MyCollection(DateTime minDate, DateTime maxDate)
        {
            _minDate = minDate;
            _maxDate = maxDate;
        }


        public IEnumerator GetEnumerator()
        {
            for( var i = _minDate; i <= _maxDate; i = i.AddDays(7))
                yield return i;
        }
    }


    class MyClass
    {
        public String Value;

        public override bool Equals(object obj)
        {
            return this.Value == ((MyClass) obj).Value;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //DateTime first = DateTime.Now;
            //TestSet();
            //DateTime second = DateTime.Now;
            //Console.WriteLine((int) (second - first).TotalSeconds);
            // TestSet();

            TestDict();

            Console.ReadKey();
        }

        public void test()
        {
            string text;
            text = Console.ReadLine();
            string[] sentences = text.Split('.');
            Console.WriteLine(sentences.Length);

            string maxSentence = "";
            foreach (var sentence in sentences)
            {
                if (sentence.Split(' ').Length > maxSentence.Split(' ').Length)
                {
                    maxSentence = sentence;
                }
            }
            Console.WriteLine(maxSentence);

            Console.ReadKey();            
        }

        public static void TestContains()
        {
            List<MyClass> list = new List<MyClass>();

            MyClass ob1 = new MyClass();
            ob1.Value = "home";

            MyClass ob2 = new MyClass();
            ob2.Value = "home";

            list.Add(ob1);

            Console.WriteLine(list.Contains(ob1)); //1 

            Console.WriteLine(list.Contains(ob2)); //2 


        }


        public static void TestList()
        {
            int[] mas = new int[100000];
            Random random = new Random(1000000);

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(1000000);
            }

            List<int> result = new List<int>();

            foreach (var word in mas)
            {
                if (!result.Contains(word))
                {
                    result.Add( word );
                }
            }


            Console.WriteLine(result.Count);


        }

        public static void TestSet()
        {
            int[] mas = new int[100000];
            Random random = new Random(1000000);
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(1000000);
            }

            HashSet<int> result = new HashSet<int>();


            foreach (var i in mas)
            {
                result.Add(i);
            }

            Console.WriteLine(result.Count);
        }

        public static void TestDict()
        {
            string[] words = {"home", "child", "home", "child", "me"};
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict[word] = 1; //  dict.Add(word, 1);
            }

            foreach (var val in dict)
            {
                Console.WriteLine(  val.Key + "  " + val.Value  );
            }

        }

    }


}

//  IEnumerable  --> enumerator
        // foreach
//  ICollection  --> Count, 
//  IList        --> [] 
       // Array, List<>