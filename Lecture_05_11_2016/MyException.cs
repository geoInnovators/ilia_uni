using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_05_11_2016
{
    public class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }
}
