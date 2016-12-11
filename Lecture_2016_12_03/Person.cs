using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2016_12_03
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Sex { get; set; }
        public DateTime BirthDate { get; set; }

        public string SexString
        {
            get
            {
                return Sex ? "მამრობითი" : "მდედრობითი";
            }
        }

        public static List<Person> Persons = new List<Person>();

        public int CompareTo(Person other)
        {
            // -1, 0, 1
            if (this.BirthDate < other.BirthDate)
                return -1;
            if (this.BirthDate == other.BirthDate)
                return 0;
            return 1;
        }

        public static int CompareByName(Person p1, Person p2)
        {
            return p1.Name.CompareTo(p2.Name);
        }

        public static int CompareByLastName(Person p1, Person p2)
        {
            return p1.LastName.CompareTo(p2.LastName);
        }
    }
}
