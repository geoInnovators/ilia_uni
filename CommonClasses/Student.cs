using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Student
    {
        #region fields
        public string Name;
        public string LastName;
        public int Age;
        public string PersonalId;
        public StudentTypes StudentType;

        private string _isGeorgian;

        public int[] Credits;

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

        private bool _isCreditsGood;
        public bool IsCreditGood
        {
            get
            {
                if (_isCreditsGood == true)
                    return _isCreditsGood;

                int minCreditsForB = 30;
                int minCreditsForM = 20;
                int minCreditsForP = 10;

                int sum = 0;
                foreach(int credit in Credits)
                {
                    sum += credit;
                }

                if( StudentType  == StudentTypes.Bachelor)
                    return (sum >= minCreditsForB);
                if (StudentType == StudentTypes.Master)
                    return (sum >= minCreditsForM);
                if (StudentType == StudentTypes.Phd)
                    return (sum >= minCreditsForP);
                return false;

            }
            set
            {
                _isCreditsGood = value;
            }
        }
        #endregion

        #region static fields
        public static Student[] Students;
        public static int StudentsAge(int age)
        {
            int count = 0;
            foreach (var s in Students)
            {
                if (s.Age == age)
                    count++;
            }
            return count;
        }
        #endregion
    }

    public enum StudentTypes
    {
        Bachelor,
        Master,
        Phd
    }
}
