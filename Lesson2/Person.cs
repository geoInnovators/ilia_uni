using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    abstract class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public abstract string displayName(string lang);
    }

}
