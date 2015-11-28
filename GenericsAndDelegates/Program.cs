using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndDelegates
{
    public class Stack<T>
    {
        int position;
        T[] data = new T[100];
        public void Push(T obj) { data[position++] = obj; }
        public T Pop() { return data[--position]; }
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
