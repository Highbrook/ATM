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
    public partial class WithdrawScreen : Form
    {
        private int currentAccountBalance = 3000;
        public WithdrawScreen()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void oneKButton_Click(object sender, EventArgs e)
        {
            if (enoughFunds(Int32.Parse(oneKButton.Text)))
            {
                payout();
            }
            else if (!enoughFunds(Int32.Parse(oneKButton.Text)))
            {
                notEnoughFundsWindow();
            }
            else
            {
                errorOccurred();
            }
        }

        private void twoKButton_Click(object sender, EventArgs e)
        {
            if (enoughFunds(Int32.Parse(twoKButton.Text)))
            {
                payout();
            }
            else if (!enoughFunds(Int32.Parse(twoKButton.Text)))
            {
                notEnoughFundsWindow();
            }
            else
            {
                errorOccurred();
            }
        }

        private void threeKButton_Click(object sender, EventArgs e)
        {
            if (enoughFunds(Int32.Parse(threeKButton.Text)))
            {
                payout();
            }
            else if (!enoughFunds(Int32.Parse(threeKButton.Text)))
            {
                notEnoughFundsWindow();
            }
            else
            {
                errorOccurred();
            }
        }

        private void fiveKButton_Click(object sender, EventArgs e)
        {
            if (enoughFunds(Int32.Parse(fiveKButton.Text)))
            {
                payout();
            }
            else if (!enoughFunds(Int32.Parse(fiveKButton.Text)))
            {
                notEnoughFundsWindow();
            }
            else
            {
                errorOccurred();
            }
            
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CustomWithdrawScreen customWithdrawScreen = new CustomWithdrawScreen();
            customWithdrawScreen.ShowDialog();
            this.Show();
        }

        public void notEnoughFundsWindow()
        {
            this.Visible = false;
            InsufficientFundsScreen insufficientFundsWindow = new InsufficientFundsScreen();
            insufficientFundsWindow.ShowDialog();
            this.Show();
        }

        public void errorOccurred()
        {
            this.Visible = false;
            WithdrawFailedScreen withdrawFailedScreen = new WithdrawFailedScreen();
            withdrawFailedScreen.ShowDialog();
            this.Show();
        }

        public bool enoughFunds(int cashOutValue)
        {
            // TODO
            // Check if client has enough funds on their account
            if (currentAccountBalance >= cashOutValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void payout()
        {
            // Do payout logic
            this.Visible = false;
            WithdrawSuccessScreen withdrawSuccessScreen = new WithdrawSuccessScreen();
            withdrawSuccessScreen.ShowDialog();
            this.Show();
        }
    }
}
