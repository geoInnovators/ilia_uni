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

namespace Lecture_24_12_20162
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<WordsPair> WordsBase;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if(f.ShowDialog() == DialogResult.OK)
            {
                WordsBase = new List<WordsPair>();
                using (StreamReader reader = new StreamReader(f.FileName))
                {
                    string s;
                    while( (s = reader.ReadLine()) != null)
                    {
                        string[] words = s.Split(',');
                        /// obieqtis sheqmna
                        WordsPair w = new WordsPair(words[0], words[1]);
                        WordsBase.Add(w);
                    }
                    MessageBox.Show("ფაილი ჩაიტვირთა წარმატებით");
                }

            }
        }
        int index;
        private void label1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Text = "";
            Random r = new Random();
            index = r.Next(WordsBase.Count);
            label1.Text = WordsBase[index].Geo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(WordsBase[index].Eng == textBox1.Text.Trim())
            {
                label2.Text = "სწორია";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "არასწორია, სწორი პასუხია :" + WordsBase[index].Eng;
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
