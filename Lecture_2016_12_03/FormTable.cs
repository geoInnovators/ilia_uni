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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            if( f.ShowDialog(this) == DialogResult.OK)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Person.Persons;
            }
        }
    }
}
