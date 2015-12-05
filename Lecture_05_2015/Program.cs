using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_05_2015
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
          
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName; 
        }

        public static void Print(Person[] mas)
        {
            foreach (var i in mas)
            {
                Console.WriteLine( i.Name + " " + i.LastName );
            }
        }

    }


    delegate  int TestDelegate(int a);

    class Program
    {
        public static void TestSort()
        {
            Person[] mas = new[]
            {
                new Person("avto", "rukhadze"),
                new Person("temo", "tutberidze"),
                new Person("nino", "mumladze")
            };
            Console.WriteLine("dalageba saxelebis mixedvit");
            Array.Sort(mas, compareByName);
            Person.Print(mas);
            Console.WriteLine("dalageba gvaredbis  mixedvit");
            Array.Sort(mas, compareByLastName);
            Person.Print(mas);
        }

        //a =  nino mumladze
        //b =  avto rukhadze
        public static int compareByName(Person a, Person b)
        {
            return a.Name.CompareTo(b.Name); 
        }
        public static int compareByLastName(Person a, Person b)
        {
            return a.LastName.CompareTo(b.LastName);
        }


        public int I { get; set; }



        static void Main(string[] args)
        {
            TestSort();

            //TestDelegate a;

            //Program p1 = new Program();
            //p1.I = 20;
            //a = Transform2;
            //Console.WriteLine(a(5));

            //Program p2 = new Program();
            //p2.I = 25;
            //a = Transform2;
            //Console.WriteLine(a(5));



        }


        public  int Transform4(int a)
        {
            return a*I;
        }


        public static int Transform2(int a)
        {
            return a*a;
        }
        public static int Transform3(int a)
        {
            return a * a * a;
        }

    }
}
