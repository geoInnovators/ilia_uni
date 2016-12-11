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
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();

        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Person.Persons;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            if( f.ShowDialog(this) == DialogResult.OK)
                RefreshGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.ColumnIndex == 4  && e.RowIndex > -1 )
            {
                var person = Person.Persons[e.RowIndex];
                Form1 f = new Form1(person);
                if (f.ShowDialog(this) == DialogResult.OK)
                    RefreshGrid();
            }
            if (e.ColumnIndex == 5 && e.RowIndex > -1)
            {
                if (MessageBox.Show("გსურთ წაშლა?", "შეკითხვა", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Person.Persons.RemoveAt(e.RowIndex);
                    RefreshGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person.Persons.Sort();
            RefreshGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person.Persons.Sort( Person.CompareByName  );
            RefreshGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person.Persons.Sort(Person.CompareByLastName);
            RefreshGrid();
        }
    }
}
