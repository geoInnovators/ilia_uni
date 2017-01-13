using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2016_12_17_Files
{
    public class MyDictionary
    {
        public List<DictEntry> Words { get; set; }
    }

    public class DictEntry
    {
        public string Geo { get; set; }
        public string End { get; set; }
    }
}
