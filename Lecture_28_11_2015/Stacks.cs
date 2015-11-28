using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_28_11_2015
{


    public class Stack<T> where T : struct

    {
        private int position;
        private T[] data = new T[100000];

        public void Push(T value) { data[position++] = value; }
        public T Pop() { return data[--position]; }
    }

}
