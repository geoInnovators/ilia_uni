using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1996, 02, 21);
            Student st = new Student("dato", "rukhadze", dt);
            Lecturer l = new Lecturer("aaa", "bbb", new DateTime(1956, 02, 03));
            Console.WriteLine(st.GetFullName());
            Console.WriteLine(l.GetFullName());

            st.Payment = 34.23m;
            Person p = st;
            Console.WriteLine(p.Name);  // dato
            Console.WriteLine(st.Payment);  // 34.23 
            Student a = (Student)p; // tipis dayvana
            // Lecturer al = (Lecturer)p; // runtime error
            bool b = p is Lecturer; // true
            Console.WriteLine(b);
            Console.ReadLine();
            // Person p = new Person("dato", "rukhadze", dt);

        }
    }


}
