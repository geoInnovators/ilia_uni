using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Lecturer : Person
    {
        public int Salary;

        public Lecturer(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        public override string GetFullName()
        {
            return string.Format("lecturer {0} {1}", Name, LastName);
        }
    }
}
