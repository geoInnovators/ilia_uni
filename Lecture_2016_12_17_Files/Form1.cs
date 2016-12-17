using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_2016_12_17_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create("test.txt"))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine( textBox1.Text  );
                writer.Write("sdfwgwgweg");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            if(f.ShowDialog() == DialogResult.OK){
                using (StreamWriter writer = new StreamWriter(f.FileName))
                {
                    writer.WriteLine(textBox1.Text);
                }
            }

            StreamReader r = new StreamReader("sdge");
            
        }
        List<string> list = new List<string>();
        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if( f.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader sr = new StreamReader(f.FileName))
                {
                    string s = sr.ReadLine();
                    while (s != null)
                    {
                        list.Add(s);
                        s = sr.ReadLine();
                    }
                }
                foreach(var s in list)
                {
                    textBox1.Text = textBox1.Text + s + "\r\n";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            list.Sort();
            foreach (var s in list)
            {
                textBox2.Text = textBox2.Text + s + "\r\n";
            }
        }
    }
}
