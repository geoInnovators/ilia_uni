using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_24_12_2016
{
    public class DictionaryEntry
    {
        public string Eng { get; set; }
        public string Geo { get; set; }

        public DictionaryEntry(string eng, string geo)
        {
            Eng = eng;
            Geo = geo;
        }
    }
}
