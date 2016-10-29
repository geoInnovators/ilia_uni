using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;

namespace Lecture_22_10_2016_Introduction
{


    class Program
    {
        static void Main(string[] args)
        {
            Student avto;  // 1. cvladis agwera
            avto = new Student("avtandil", "rukhadze"); // 2. cvladze obieqtis minicheba
            avto.PersonalId = "600034534534";

            Console.WriteLine(avto.IsStudentGeorgianProrety); // no
            avto.IsStudentGeorgianProrety = "yes";
            Console.WriteLine(avto.GetPersonName()); // avtandil rukhadze


            Student[] students = new Student[3]; // studentebis masivis sheqmna

            students[0] = new Student("avtandil", "rukhadze", 30);
            students[1] = new Student("davit", "mgeladze", 20);
            students[2] = new Student("tamar", "nodia", 25);
            
            Console.WriteLine(GetOldestStudent(students).GetPersonName());
            // avtandil rukhadze

            Console.ReadLine();
        }

        static Student GetOldestStudent(Student[] students)
        {
            int max = students[0].Age;
            Student answer = students[0];
            foreach (Student mimdinare in students)
            {
                if (mimdinare.Age > max)
                {
                    max = mimdinare.Age;
                    answer = mimdinare;
                }
            }
            return answer;
        }
    }
}
