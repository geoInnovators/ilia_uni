using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_19_11_2016
{

    class Program
    {
        static void Main(string[] args)
        {

            DelegateOperations();
            ShowForm();
        }

        static void DelegateOperations()
        {
            int[] mas = {3, 5,4};
            Console.WriteLine(OperationMethods.ArrayOperations( mas, OperationMethods.GetMax) ); // იპოვის მასივში მაქსიმალურ ელემენტს
            Console.WriteLine(OperationMethods.ArrayOperations(mas, OperationMethods.GetMin)); // იპოვის მასივში მინიმალურ ელემენტს
            Console.WriteLine(OperationMethods.ArrayOperations(mas, OperationMethods.GetSum)); // დათვლის მასივის ჯამს
        }
        // პარამეტრად გადმოცემულ ორ ელემენტს უცვლის ადგილს
        static void Swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

        // ფორმის გამოძახება
        public static void ShowForm()
        {
            MyForm frm = new MyForm();
            frm.ShowDialog();
        }
    }
}
