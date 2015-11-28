using System;
namespace PirveliShualeduri
{
    class Lecture
    {
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public String CourseName { get; set; }
        public Lecture(DayOfWeek day, TimeSpan startTime, String courseName)
        {
            Day = day;
            StartTime = startTime;
            CourseName = courseName;
        }
    }

    class Schedule
    {
        public Lecture[] Lectures { get; set; }

        public Schedule(Lecture[] lectures)
        {
            Lectures = lectures;
        }
        public int NumberofLectures(String name)
        {
            int result = 0;
            foreach (var lecture in Lectures)
            {
                if (lecture.CourseName == name)
                    result++;
            }


            return result;
        }
        public int TotalNumberofLectures(String name)
        {
            int result = 0;
            DateTime from = new DateTime(2015, 9, 21);
            DateTime to = new DateTime(2016, 1, 29);
            foreach (var lecture in Lectures)
            {
                if (lecture.CourseName != name) continue;
                DateTime i = from.AddDays((int)lecture.Day - (int)from.DayOfWeek);
                while (i <= to)
                {
                    result++;
                    i = i.AddDays(7);
                }
            }
            return result;
        }

        public String GetCurrentCourse()
        {
            DateTime current = DateTime.Now;
            foreach (var lecture in Lectures)
            {
                if (lecture.Day == current.DayOfWeek && lecture.StartTime.Hours == current.Hour)
                    return lecture.CourseName;
            }
            return String.Empty;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lecture[] array = new[]
            {
                new Lecture(DayOfWeek.Saturday, TimeSpan.FromHours(9), "C#"),
                new Lecture(DayOfWeek.Saturday, TimeSpan.FromHours(10), "C#"),
                new Lecture(DayOfWeek.Saturday, TimeSpan.FromHours(11), "C#"),
                new Lecture(DayOfWeek.Friday, TimeSpan.FromHours(10), "ASP.NET")
            };
            Schedule sc = new Schedule(array);
            Console.WriteLine(sc.NumberofLectures("C#")); // 3
            Console.WriteLine(sc.NumberofLectures("ASP.NET")); // 1
            Console.WriteLine(sc.TotalNumberofLectures("C#")); // 54
            Console.WriteLine(sc.GetCurrentCourse()); // 
        }
    }
}
