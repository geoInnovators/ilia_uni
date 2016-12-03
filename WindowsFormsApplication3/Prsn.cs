using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class Prsn
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Sex { get; set; }

        public string SexString
        {
            get
            {
                return Sex == true ? "მამრ" : "მდედრ";
            }
        }

        public static List<Prsn> Persons = new List<Prsn>();
    }
}
