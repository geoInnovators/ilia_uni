using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerExample
{
    class TestForm : Form
    {
        private Button button1;
        public TestForm()
        {
            this.button1 = new Button();
            this.button1.Location = new Point(120, 88);
            this.button1.Size = new Size(150, 23);
            this.button1.Text = "damachire xeli";
            this.button1.Click += button1_Click;
 
            ClientSize = new Size(350, 261);
            Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("goood");
            //MessageBox.Show(  "dd");
        }

    }





    class Program
    {
        static void Main(string[] args)
        {
            TestForm t = new TestForm();
            t.ShowDialog();
            Console.WriteLine("aaa");
        }
    }
}
