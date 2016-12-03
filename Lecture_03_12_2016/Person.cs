using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03_12_2016
{
    public class Person
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
    }
}
