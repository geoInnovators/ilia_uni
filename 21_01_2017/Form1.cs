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

namespace _21_01_2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "დაიწყო ოპერაციის შესრულება...";
            Thread t = new Thread(LongRunningOperation);
            t.Start();
            
        }
        // 10 წამიანი ოპერაცია
        void LongRunningOperation()
        {
            Thread.Sleep(10000);

            this.BeginInvoke(new Action(AfterLongRunningOperation));  
        }

        void AfterLongRunningOperation()
        {
            label1.Text = "ოპერაცია დასრულდა წარმატებით";
        }

        Thread t;
        private void button2_Click(object sender, EventArgs e)
        {
            t = new Thread(TimerOperation);
            t.Start();
        }

        int i;
        void TimerOperation()
        {
            for (i = 1; ; i++)
            {
                Thread.Sleep(100);
                this.BeginInvoke(new Action(IncrementLabel));
            }
        }

        void IncrementLabel()
        {
            label2.Text = DateTime.Now.ToString("T");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t.Abort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("T");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        long a, b;
        private void button5_Click(object sender, EventArgs e)
        {
            a = long.Parse(textBox1.Text);
            b = long.Parse(textBox2.Text);
            if( b > a)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }
            Thread t = new Thread(FindUSG);
            t.Start();
        }
        long result;
        void FindUSG()
        {
            result = calculateUSG(a, b);
            this.BeginInvoke(new Action(updateUSGLabel));
        }

        void updateUSGLabel()
        {
            label3.Text = result.ToString();
        }

        long calculateUSG(long a, long b)
        {
            if (b == 0) return a;
            return calculateUSG(b, a % b);
        }
    }
}
