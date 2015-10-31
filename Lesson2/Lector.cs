using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Lector : Person
    {

        public override string displayName(string lang)
        {
            if (lang == "ge")
                return String.Format("ლექტორი: {0} {1}", Name, LastName);
            else if (lang == "en")
                return String.Format("lecturer: {0} {1}", Name, LastName);
            else return "";
        }
    }
}
