using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12_11
{
    public class MyException : Exception
    {
        public MyException(string s) : base(s)
        {
            
        }
    }
}
