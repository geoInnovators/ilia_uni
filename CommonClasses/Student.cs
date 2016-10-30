using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public enum StudentTypes
    {
        Bachelor,
        Master,
        Phd
    }

    public class Student
    {
        #region fields
        public string Name;
        public string LastName; 
        public int Age; 
        public string PersonalId; 

        private string _isGeorgian;

        public int[] Credits;
        public StudentTypes StudentType;
        #endregion

        #region constructors
        public Student(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        public Student(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }
        #endregion

        #region methods
        public string IsStudentGeorgian()
        {
            if (PersonalId.Length == 11)
                return "yes";
            return "no";
        }
        public string GetPersonName()
        {
            return Name + " " + LastName;
        }

        public void TestThis(int Age)
        {
            
            Age = 34;
        }
        #endregion

        #region properties
        public string IsStudentGeorgianProrety
        {
            get
            {
                if (PersonalId.Length == 11)
                    return "yes";
                return "no";
            }
            set
            {
                _isGeorgian = value;
            }
        }

        public bool IsStudentGood
        {
            get
            {
                int sum = 0;
                foreach(int credit in Credits)
                {
                    sum += credit;
                }
                return sum >= 50;
            }
        }

        #endregion

        #region static member
        public static Student[] Students;
        public static int GetStudentsCountByAge(int age)
        {
            int count = 0;
            foreach(Student s in Students)
            {
                if (s.Age == age) count++;
            }
            return count;
        }
        #endregion
    }
}
