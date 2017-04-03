using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    class Program
    {
        static void Print(string a)
        {
            Console.WriteLine(a);
        } 
        static void Main(string[] args)
        {
            Person p = new Person("avto", "rukhadze", PersonType.Lecturer);
            Console.WriteLine((int)p.PersonT); // 0
            Console.WriteLine(p.GetFullName);
            Console.ReadLine(); 

            p.PersonT = PersonType.Student; // minicheba
            Console.WriteLine(p.Name);
            Person.Citizen = "georgian";
            Console.WriteLine(Person.Citizen);
            Person p1 = new Person("aaa", "bbbb", PersonType.Lecturer);
            Console.WriteLine(p1.Name);   //  aaa
            //Program t = new Program();
            Print("aaaaa");

            Console.WriteLine(p1.GetFullName);   //  aaa
            p1.GetFullName = "sdfwegewgew";

            Point point = new Point(4, 5);
            Point point1 = point;
            point1.X = 100;
            Console.WriteLine(point.X); // ra daibechdeba ? 

        }
    }
    class Person
    {
        public string Name; // veli
        public string LastName;  // veli
        public static string Citizen;  // statikuri veli
        public PersonType PersonT; // student, lector, master
        public Person(string name, string lastName, PersonType personT) // konstruqtori
        {
            Name = name;
            LastName = lastName;
            PersonT = personT;
        }

        public string GetFullName  // tviseba,  property
        {
            get  // dabruneba
            {
                return Name + " " + LastName + "  " + PersonT;
            }
            set
            {
                Name = value;
            }
        }

    }
    struct Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x; Y = y;
        }
    }

    enum PersonType
    {
        Student,  // 0
        Lecturer,  // 1
        Master   // 2
    }
}
