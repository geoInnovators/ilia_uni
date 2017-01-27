using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int j = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "მოითმინეთ...";
            Thread t = new Thread(DoWork);
            t.Start();
            // label1.Text = "დასრულდა წარმატებით";
        }

        void DoWork()
        {
            j = 5;
            for (int i = 0; i < 1000000000; i++) { }
            this.BeginInvoke(new Action(AfterWork));
            
        }

        void AfterWork()
        {
            label1.Text = "დასრულდა წარმატებით";
        }

        Thread th;
        private void button3_Click(object sender, EventArgs e)
        {
            th = new Thread(DrawRectangles);
            th.Start();
        }



        void DrawRectangles()
        {
            Random r = new Random();
            var g = this.CreateGraphics();
            while (true)
            {
                Thread.Sleep(500);
                g.FillRectangle(Brushes.Red, r.Next(this.Width), r.Next(this.Height), 50, 50);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            th.Abort();
        }
    }
}
