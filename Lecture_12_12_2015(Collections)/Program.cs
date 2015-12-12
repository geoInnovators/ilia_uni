using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    class Program
    {
        static void Main(string[] args)
        {
            

            // Array
            

            int[][] matrica = new int[5][];

            matrica[0] = new int[] {0, 1};  // 2
            matrica[1] = new int[] {0,1,6,2, 34};  // 5
            matrica[2] = new int[] {3,1,6};  // 3
            matrica[3] = new int[] {2,1,6};  // 3
            matrica[4] = new int[] {};  // 0

            int max = int.MinValue;
            foreach (var str in matrica)
            {
                foreach (var i in str)
                {
                    if (i > max)
                        max = i;
                }
            }
            Console.WriteLine(max);


            int[,,] matrica1 = new int[10,10,10];
            //Console.WriteLine(matrica1[0,1,2]);
            

            // 6, 1
            //Console.WriteLine(matrica[0][2]);
            int[] a = { 1, 2, 3 };
            Array.Sort(a);  //
            Array.Reverse(a);  // {  3, 2, 1  }
            string[] b = {"abb", "ccc", "ddd"};
            string[] s = (string[])b.Clone();

            

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
    }


}
