using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
        }

        private void Add_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            if(f.ShowDialog() == DialogResult.OK)
            {
                f.Dispose();
                Prsn.Persons.Add(f.P);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Prsn.Persons;
                
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.ColumnIndex == 5)
            {
                
            }
        }
    }
}
