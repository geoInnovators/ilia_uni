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

namespace WindowsFormsApplication5
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
            timer1.Start();

        }

        void BackgroundOperation()
        {
            for(int i=0; ;i++)
            {
                Thread.Sleep(100);
                this.BeginInvoke(new Action(UpdateLabel));
            }
        }

        void UpdateLabel()
        {
            label1.Text = DateTime.Now.ToString("T");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }
    }
}
