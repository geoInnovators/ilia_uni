using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testNamespace
{
    class Student
    {
        public string Name;
        public string LastName;
        public string GetFullName()
        {
            string result = Name + " " + LastName;
            return result;
        }
        private void WriteFullName()
        {
            Console.WriteLine(Name + " " + LastName);
        }

        void WriteName(string Name)
        {
            Console.WriteLine(Name);
        }

        public Student(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}