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
        Person person;
        // add
        public Form1()
        {
            InitializeComponent();
            btnEdit.Visible = false;
        }
        // edit
        public Form1(Person p)
        {
            InitializeComponent();
            person = p;
            btnAdd.Visible = false;
            tbxName.Text = p.Name;
            tbxLastName.Text = p.LastName;
            rbtnMale.Checked = p.Sex;
            rbtnFemale.Checked = !p.Sex;
            dtpBirthDate.Value = p.BirthDate;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            person.Name = tbxName.Text;
            person.LastName = tbxLastName.Text;
            person.Sex = rbtnMale.Checked;
            person.BirthDate = dtpBirthDate.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
