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

namespace _14_01_2017
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
            t = new Thread(BackgroundOperation);
            t.Start();
        }

        private void BackgroundOperation()
        {
            Random r = new Random();
            for(int i=0;i < 100; i++)
            {
                Thread.Sleep(1000);
                var g = this.CreateGraphics();
                g.FillRectangle(Brushes.Blue, r.Next(this.Width), r.Next(this.Height), 100, 50);
            }
        }
        private void updateLabel()
        {
            label1.Text =  DateTime.Now.ToString("HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Abort();
        }
    }
}
