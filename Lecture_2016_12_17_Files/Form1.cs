using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        private void button3_Click(object sender, EventArgs e)
        {
            MyDictionary d = new MyDictionary();
            d.Words = new List<DictEntry>();
            d.Words.Add(new DictEntry
            {
                End = "aaa",
                Geo = "bbb"
            });
            XmlSerializer serializer = new XmlSerializer(typeof(MyDictionary));
            using (StreamReader reader = new StreamReader(@"myxml.xml"))
            {
                d = (MyDictionary)serializer.Deserialize(reader);
            }


            //using (StreamWriter writer = new StreamWriter(@"myxml.xml"))
            //{
            //    serializer.Serialize(writer, d);
            //}



            var fromAddress = new MailAddress("avtoruxadze@gmail.com", "From Name");
            var toAddress = new MailAddress("avtoruxadze@gmail.com", "To Name");
            const string fromPassword = "Ruxia0707";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
