using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Person(String name, string lastname, DateTime birthday)
        {
            Name = name;
            LastName = lastname;
            BirthDate = birthday;

        }

        public DateTime GetNearestBD
        {
            get
            {
                DateTime thisyear = new DateTime(DateTime.Now.Year, BirthDate.Month, BirthDate.Day);
                DateTime nextyear = thisyear.AddYears(1);
                if (DateTime.Now > thisyear)
                    return nextyear;
                return thisyear;
            }
        }


        static void PrintNearestBd(Person[] array)
        {
            DateTime minBD = DateTime.MaxValue;

            foreach (var bd in array)
            {
                if (minBD > bd.GetNearestBD)
                    minBD = bd.GetNearestBD;
            }

            Console.WriteLine(minBD);

            foreach (var bd in array)
            {
                if (minBD == bd.GetNearestBD)
                    Console.WriteLine(String.Format("{0} {1} {2}", bd.Name, bd.LastName, bd.BirthDate));
            }


            //Console.WriteLine(minBD);


        }





        static void Main(string[] args)
        {
            Person[] array = new[]
            {

                new Person("avto", "rukhadze", new DateTime(1987, 08, 30)),
                new Person("zura", "esartia", new DateTime(1986, 12, 05)),
                new Person("tornike", "benidze", new DateTime(1987, 07, 07)),
                new Person("anri", "nishnianidze", new DateTime(1986, 10, 23)),
                new Person("tornike", "datiashvili", new DateTime(1988, 12, 05))
    
            };
            Person.PrintNearestBd(array);
        }
    }
}