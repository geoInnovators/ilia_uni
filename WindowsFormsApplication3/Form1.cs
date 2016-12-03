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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Prsn P;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            P = new Prsn();
            P.Name = tbxName.Text;
            P.LastName = tbxLastName.Text;
            P.BirthDate = dtpBirthDate.Value;
            P.Sex = rbtFemale.Checked;
            this.DialogResult = DialogResult.OK;
        }
    }
}
