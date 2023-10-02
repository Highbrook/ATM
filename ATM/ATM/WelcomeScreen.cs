using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            InsertCardDevButton.Visible = true;
            InsertCardDevButton.Enabled = true;
        }

        private void InsertCardDevButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PinConfirmation pinConfirmation = new PinConfirmation();
            pinConfirmation.Show();
        }
    }
}
