using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_2016_12_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = tbxName.Text;
            p.LastName = tbxLastName.Text;
            p.Sex = rbtnMale.Checked;
            p.BirthDate = dtpBirthDate.Value;
            Person.Persons.Add(p);
           // MessageBox.Show("ახალი ჩანაწერი დაემატა წარმატებით");
            this.DialogResult = DialogResult.OK;
        }
    }
}
