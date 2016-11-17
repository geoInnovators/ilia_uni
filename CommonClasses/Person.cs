using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public abstract class Person
    {
        public string Name;
        public string LastName;
        public int Age;
        public string PersonalId;

        public abstract string GetFullName();
    }
}
