using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_05_2015
{
    class Person : IEquatable<Person>
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

        public bool Equals(Person other)
        {
            return (Name == other.Name) && (LastName == other.LastName);
        }

        public override int GetHashCode()
        {
            return (Name + LastName).GetHashCode();
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
            //TestSort();
            var p = new Person("avto", "rukhadze");
            var p1 = new Person("avto", "rukhadze");
            Dictionary<Person, int> dict = new Dictionary<Person, int>();
            dict[p] = 1;
            dict[p1] = 3;
            foreach (var item in dict)
            {
                Console.WriteLine( item.Key + " " + item.Value  );
            }
            int s = 6;
            s++;
            int[] a = new int[s];
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
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
