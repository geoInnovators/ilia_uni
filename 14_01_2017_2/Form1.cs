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

namespace _14_01_2017_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread t;
        private void button1_Click(object sender, EventArgs e)
        {
            // label1.Text = "დაიწყო ოპერაციის შესრულება...";
            t = new Thread(BackgroundOperation);
            t.Start();
        }

        void BackgroundOperation()
        {
            Random r = new Random();
            var g = this.CreateGraphics();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                
                g.FillRectangle(Brushes.Blue, r.Next(this.Width), r.Next(this.Height), 50, 50 );

                //this.BeginInvoke(new Action(UpdateLabel));
            }

        }

        int i = 0;
        void UpdateLabel()
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Abort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // label1.Text = "დაიწყო ოპერაციის შესრულება...";
            t = new Thread(DrawCircle);
            t.Start();
        }

        void DrawCircle()
        {
            Random r = new Random();
            var g = this.CreateGraphics();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                g.FillEllipse(Brushes.Red, r.Next(this.Width), r.Next(this.Height), 50, 50);

                //this.BeginInvoke(new Action(UpdateLabel));
            }

        }
    }
}
