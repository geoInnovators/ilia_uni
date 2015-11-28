using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_28_11_2015
{
    class Person : IComparable<Person>
    {
        #region properties
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Person(String name, string lastname, DateTime birthday)
        {
            Name = name;
            LastName = lastname;
            BirthDate = birthday;

        }
        #endregion

        public int CompareTo(Person other)
        {
            if (this.BirthDate > other.BirthDate) return 1;
            if (this.BirthDate == other.BirthDate) return 0;
            return -1;
        }
    }
}
