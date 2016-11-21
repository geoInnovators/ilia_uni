using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_19_11_2016
{
    class MyForm : Form
    {
        public MyForm()
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.Click += ButtonClicked;
        }

        public void ButtonClicked(object sender, EventArgs a)
        {
            Console.WriteLine("pirvel gilaks daechira");
        }
    }
}
