using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12_11
{
    public interface IliauniClasses
    {
        DateTime getCreateDate();
    }

    public abstract class Figure
    {
        public int M;
        public abstract int Perimeter();

        public virtual string Test()
        {
            return "figure";
        }

        public Figure(int m)
        {
            Console.WriteLine("shemovida");
        }

        public override string ToString()
        {
            return "Figure";
        }
    }

    public class Rectangle : Figure, IliauniClasses
    {
        public int M;
        private int[] Gverdebi;
        public override int Perimeter()
        {
            int result = 0;
            foreach (var gverdi in Gverdebi)
            {
                result += gverdi;
            }
            return result;
        }

        public override string Test()
        {
            
            return "Rectangle";
        }

        public Rectangle() : base(5) { }
        public DateTime getCreateDate()
        {
            return new DateTime(2016,11,12);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = Console.ReadLine();
                int i;
                if (int.TryParse(s, out i) == false)
                {
                    throw new MyException("sheiyvanet wesieri ricxvi");
                }
                Console.WriteLine(10/i);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("moxda 0 ze gayofa");
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message); // user friendly
            }
            catch (Exception ex)
            {
                // logging exception
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
