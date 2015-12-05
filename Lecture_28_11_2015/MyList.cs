using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_28_11_2015
{
    class MyList<T>
    {
        private T[] mas = new T[1000];

        int length;

        public void Add(T a)
        {
            mas[length] = a;
            length++;
        }
        public T Get(int index)
        {
            return mas[index];
        }
        public int Length
        {
            get
            {
                return length;
            }
        }


    }
}
