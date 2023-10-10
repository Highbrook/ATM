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
    public partial class WithdrawSuccessScreen : Form
    {
        public WithdrawSuccessScreen()
        {
            InitializeComponent();
        }

        public void LabelSelection(int success)
        {
            if (success == 0)
            {
                IncorrectValue.Visible = false;
                InsufficientFundsLabel.Visible = false;
                SuccessfulTransactionLabel.Visible = true;
            }
            else if (success == 1)
            {
                IncorrectValue.Visible = false;
                InsufficientFundsLabel.Visible = true;
                SuccessfulTransactionLabel.Visible = false;
            }
            else if (success == 2)
            {
                IncorrectValue.Visible = true;
                InsufficientFundsLabel.Visible = false;
                SuccessfulTransactionLabel.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
