using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    class TestForm : Form
    {
        public Button button;

        public Button crearButton;

        private Label l;

        public TestForm()
        {
            button = new Button();
            button.Text = "damachire";
            this.Controls.Add(button);
            // qmedeba eventze
            button.Click += ButtonClicked;

            crearButton = new Button();
            crearButton.Text = "clear text";
            this.Controls.Add(crearButton);
            crearButton.Left = 100;
            // qmedeba eventze
            crearButton.Click += ClearButtonClicked;


            l = new Label();
            l.Width = 400;
            l.Top = 100;
            this.Controls.Add(l);
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            l.Text = l.Text + " " + DateTime.Now.ToString("mm:ss");

        }

        private void ClearButtonClicked(object sender, EventArgs e)
        {
            l.Text = String.Empty;

        }
    }
}
