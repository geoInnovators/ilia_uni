using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    delegate void SayHelloEvent();

    abstract class   Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }
    }

    class Lecturer : Person
    {
        public Lecturer(string name) : base(name) { }

        public event SayHelloEvent SayHello;

        public void Hello()
        {
            Console.WriteLine("Hello Students");
            SayHello(); // fire event
        }
    }


    class Student : Person
    {
        public Student(string name) : base(name) { }

        public void Answer()
        {
            Console.WriteLine("Hi, My Name is  " + Name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TestForm form = new TestForm();
            form.ShowDialog();
        }

        public static void TestEvent()
        {
            Lecturer avto = new Lecturer("avto rukhadze");

            Student ali = new Student("ali pirievi");
            Student oto = new Student("oto tumanishvili");
            Student temo = new Student("temo tutberidze");

            // davaregistrire, metodebi, romlebic gamoizaxeba SayHellos
            // moxdenisas
            avto.SayHello += ali.Answer;
            avto.SayHello += oto.Answer;
            avto.SayHello += temo.Answer;

            avto.Hello();
        }


    }
}
