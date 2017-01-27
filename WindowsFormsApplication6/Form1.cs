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

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            a = long.Parse( textBox1.Text);
            b = long.Parse(textBox2.Text);
            Thread t = new Thread(longRunningoperation);
            t.Start();
        }
        long resultat;
        void longRunningoperation()
        {
            resultat = a > b ? USG(a, b) : USG(b, a);
            this.BeginInvoke(new Action(updateLabel));
        }

        // update label
        void updateLabel()
        {
            label1.Text = resultat.ToString();
        }

        //  პოულობს ორ რიცხვს შორის უ.ს.გ ს;
        long USG(long a, long b)
        {
            if (b == 0) return a;
            return USG(b, a % b);
        }
    }
}
