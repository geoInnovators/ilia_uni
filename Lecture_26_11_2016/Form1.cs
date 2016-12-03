using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_26_11_2016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                label1.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("შეიყვანეთ მხოლოდ რიცხვები!");
            }

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //button1.Location = 
            //    new Point(button1.Location.X + button1.Width, button1.Location.Y);
        }

        Random r = new Random();
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int k = r.Next(2);  // [0,1]
            if (k == 0) k = -1;
            button1.Location = new Point(button1.Location.X,
                button1.Location.Y + k*button1.Height
                );
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
