using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    //refference anu mimtitebliani tipi
    class Student
    {
        #region fields
        public int Age;
        public string Name;
        public string LastName;
        public int Course;
        public int[] Credits;
        #endregion

        #region methods
        public string DisplayName() {
            return Name + " " + LastName + " " + SummeryCredits;
        }
        #endregion

        #region constructors

        public Student()
        {
            //
        }
        public Student(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        #endregion

        #region properties
        public int cred;
        public int SummeryCredits
        {
            get
            {
                int res=0;
                for (int i = 0; i < Credits.Length; i++)
                    res += Credits[i];
                return res;
            }

            set 
            {
                cred = value;
            }
        }

        #endregion

        #region static members
        public static int StudentCount;

        public static void AddStudent(Student stud)
        {
            StudentCount++;
        }
        #endregion
    }
    //value type. aqvs yvelaferi rac klass ar aqvs memkvidreoba da ar aris mimtitebeli.
    struct Lesson
    {
        public days day;
        public int time;
    }

    //enum
    enum days
    { 
        sun,
        mon,
        tues
    }
}
