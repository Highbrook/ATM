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
    public partial class SelectionScreen : Form
    {
        public SelectionScreen()
        {
            InitializeComponent();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            WithdrawScreen withdrawScreen = new WithdrawScreen();
            withdrawScreen.ShowDialog();
            this.Show();
        }
    }
}
