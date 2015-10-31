using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    //refference anu mimtitebliani tipi
    abstract class Student : Person
    {
        #region fields
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

        public abstract bool Passed();


        #endregion

        #region static members
        public static int StudentCount;

        public static void AddStudent(Student stud)
        {
            StudentCount++;
        }
        #endregion



        public override string displayName(string lang)
        {
            
            if (lang == "ge")
                return String.Format("სტუდენტი: {0} {1}", Name, LastName);
            else if (lang == "en")
                return String.Format("student: {0} {1}", Name, LastName);
            else return "";
        }
    }
    //value type. aqvs yvelaferi rac klass ar aqvs memkvidreoba da ar aris mimtitebeli.
    struct Lesson
    {
        public days day;
        public int time;
    }



    class Bachelor : Student
    {
        public override string ToString()
        {
            return "Bachelor : "  +  Name + " " + LastName;
        }

        public override bool Passed()
        {
            return SummeryCredits >= 250;
        }
    }

    class Master : Student
    {
        public override  bool Passed()
        {
            return SummeryCredits >= 100;
        }

        public override string ToString()
        {
            return "Master : " + Name + " " + LastName;
        }

        public string Document;
    }



    //enum
    enum days
    { 
        sun,
        mon,
        tues
    }
}
