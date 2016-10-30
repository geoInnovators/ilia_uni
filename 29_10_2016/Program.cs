using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;


namespace _29_10_2016
{

    class Program
    {
        static void TestParams(Student a, out int b)
        {
            a.Name = "giorgi";
            b = 20;
        }
        static void Main(string[] args)
        {
            ReadNumber();
            Console.ReadKey();

            Student student1 = new Student("a", "b");
            int a = 15;
            TestParams(student1, out a);
            Console.WriteLine(student1.Name); // 
            Console.WriteLine(a);  //  20


            TestReference();
            Console.ReadLine();

            Student student = new Student("a", "b");
            student.PersonalId = "sdgwegew";
            Console.WriteLine(student.IsStudentGeorgianProrety);
            student.IsStudentGeorgianProrety = "no";

            student.Credits = new int[] { 10, 5, 15 };
            Console.WriteLine(student.IsStudentGood  ); // true false

            Student.Students = new Student[] {
                new Student("a","b",25),
                new Student("a","b",20),
                new Student("a","b"),
            };
            Console.WriteLine(Student.GetStudentsCountByAge(20));
            Console.ReadLine();
        }

        static void TestReference()
        {
            Student s1 = new Student("avto", "sdg");
            Student s2 = s1;
            s2 = new Student("dato", "sdg");
            s2 = null;
            int? a = null;
            Console.WriteLine(s1.Name);
        }

        static void TestEnum()
        {
            Student s1 = new Student("avto", "sdg");
            s1.StudentType = StudentTypes.Master;
        }
        
        static void ReadNumber()
        {
            string s = Console.ReadLine();  // s = "234"
            Console.WriteLine(s + 5);
            int a;
            if( int.TryParse(s, out a) == true)
            {
                Console.WriteLine(a + 5);
            }
            else
            {
                Console.WriteLine("invalid number!");
            }
            
        }


    }
}
