using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;
using student = CommonClasses.Student;

namespace _29_10_2016
{
    struct Point
    {
        int X;
        int Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReadNumber();
            ReferenceType();

            Student s = new Student("aa", "bb");
            s.Credits = new int[] { 8, 9, 10  };
            
            Console.WriteLine(s.IsCreditGood);
            s.IsCreditGood = true;
            Console.WriteLine(s.IsCreditGood);


            Student b = new Student("cc", "dd");
            Student.Students = new Student[]
            {
                new Student("cc", "dd", 18),
                new Student("cc", "dd", 20)
            };
            Console.WriteLine(Student.StudentsAge(20));

            // enum gamozaxeba
            var test = new Student("cc", "dd", 20);
            test.StudentType = StudentTypes.Master;

            var test2 = new Student("cc", "dd", 20);

            Console.ReadKey();
        }

        static void ReferenceType()
        {
            var student1 = new Student("cc", "dd", 20);
            var student2 = student1;
            student2.Name = "avto";
            Console.WriteLine(student1.Name); // ras dagvibechdavs

            int a;
            a = 5;
            int b = a;
            b = 7;
            Console.WriteLine(a); // ras dagvibechdavs
        }

        static void Synonyms()
        {
            String s1 = "aaa";
            string s2 = "bbbb";

            int a = 4;
            Int32 b = 5;

            student s;
            Student ss;
        }

        static void ReadNumber()
        {
            string s = Console.ReadLine(); // 27
            int a; //int.Parse(s);
            if( int.TryParse(s, out a) == true)
                Console.WriteLine(a + 5);
            else
                Console.WriteLine("sheiyvanet ricxvi!");

        }
    }
}
