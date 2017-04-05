using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_inheritance
{
    abstract class Person
    {
        public string Name;
        public string LastName;
        public DateTime BirthDate;
        public Person(string name, string lastname, DateTime birthDate)
        {
            Name = name;
            LastName = lastname;
            BirthDate = birthDate;
        }

        public abstract string GetFullName(); // abstractuli metodi

        // TODO: saxlshi
        public int GetPersonAge()
        {
            return 0;
        }
    }

    class Student : Person
    {
        public override string GetFullName()
        {
            return "Student - " + Name + " " + LastName;
        }

        public decimal Payment;
        public Student(string name, string lastname, DateTime birthDate)
            : base(name,lastname, birthDate)
        {
        }
    }
    class Lecturer : Person
    {
        public override string GetFullName()
        {
            return "Lecturer - " + Name + " " + LastName;
        }

        public decimal Salary;
        public Lecturer(string name, string lastname, DateTime birthDate)
            : base(name,lastname, birthDate)
        {
        }
    }
}
