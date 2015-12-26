using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ProgramException : Exception
    {
        public ProgramException(String messsage) : base(messsage)
        {
        }
    }
}
