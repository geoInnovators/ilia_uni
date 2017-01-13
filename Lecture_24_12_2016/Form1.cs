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

namespace Lecture_24_12_2016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<DictionaryEntry> DictionaryBase;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            string filename = null;
            if ( f.ShowDialog() == DialogResult.OK)
            {
                 filename = f.FileName;
            }
            using (StreamReader reader = new StreamReader(filename))
            {
                DictionaryBase = new List<DictionaryEntry>();
                while (true)
                {
                    string s = reader.ReadLine();
                    if (s == null) break;
                    string[] words = s.Split(',');
                    string eng = words[0];
                    string geo = words[1];
                    // ახალი ობეიქტის შექმნა
                    DictionaryEntry entry = new DictionaryEntry(eng, geo);
                    DictionaryBase.Add(entry);
                }
                MessageBox.Show("ოპერაცია დასრულდა წარმატებით");
            }
        }
        int index;
        private void label1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Text = "";
            Random r = new Random();
            index = r.Next(DictionaryBase.Count);
            label1.Text = DictionaryBase[index].Geo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myText = textBox1.Text;
            if (DictionaryBase[index].Eng == myText)
            {
                label2.Text = "სწორია";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "არასწორია, სწორი პასუხია: " + DictionaryBase[index].Eng;
                label2.ForeColor = Color.Red;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                button2_Click(null, null);
            }
        }
    }
}
