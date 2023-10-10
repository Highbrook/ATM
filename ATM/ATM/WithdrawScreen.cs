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
        // Dev section
        private int currentAccountBalance = 3000;


        private static WithdrawScreen _instance = null;
        private static readonly object padlock = new object();
        public WithdrawScreen()
        {
            if (_instance == null)
            {
                _instance = this;
                InitializeComponent();
            }
        }

        // Singleton Pattern for fetching the instance of the WithdrawScreen
        public static WithdrawScreen GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new WithdrawScreen();
                    }
                    return _instance;
                }
            }
        }

        #region Buttons
        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void oneKButton_Click(object sender, EventArgs e)
        {
            if (EnoughFunds(Int32.Parse(oneKButton.Text)))
            {
                payout();
            }
            else if (!EnoughFunds(Int32.Parse(oneKButton.Text)))
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
            if (EnoughFunds(Int32.Parse(twoKButton.Text)))
            {
                payout();
            }
            else if (!EnoughFunds(Int32.Parse(twoKButton.Text)))
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
            if (EnoughFunds(Int32.Parse(threeKButton.Text)))
            {
                payout();
            }
            else if (!EnoughFunds(Int32.Parse(threeKButton.Text)))
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
            if (EnoughFunds(Int32.Parse(fiveKButton.Text)))
            {
                payout();
            }
            else if (!EnoughFunds(Int32.Parse(fiveKButton.Text)))
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
        #endregion

        #region Responses
        public void notEnoughFundsWindow()
        {
            this.Visible = false;
            WithdrawSuccessScreen withdrawFailedScreen = new WithdrawSuccessScreen();
            withdrawFailedScreen.LabelSelection(1);
            withdrawFailedScreen.ShowDialog();
            this.Show();
        }

        public void errorOccurred()
        {
            this.Visible = false;
            WithdrawFailedScreen withdrawFailedScreen = new WithdrawFailedScreen();
            withdrawFailedScreen.ShowDialog();
            this.Show();
        }

        public bool EnoughFunds(int cashOutValue)
        {
            // TODO
            // Check if client has enough funds on their account
            int cashOutCheck = cashOutValue % 500;
            if (currentAccountBalance >= cashOutValue && cashOutCheck == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CustomEnoughFunds(int cashOutValue)
        {
            // 0 Enough Funds, 1 Incorrect Format, 2 Insufficient Funds
            int cashOutCheck = cashOutValue % 500;
            if (currentAccountBalance >= cashOutValue && cashOutCheck == 0)
            {
                return 0;
            }
            else if (currentAccountBalance >= cashOutValue && cashOutCheck != 0)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public void payout()
        {
            // Do payout logic
            this.Visible = false;
            WithdrawSuccessScreen withdrawSuccessScreen = new WithdrawSuccessScreen();
            withdrawSuccessScreen.LabelSelection(0);
            withdrawSuccessScreen.ShowDialog();
            this.Show();
        }

        public void IncorrectValueFormat()
        {
            this.Visible = false;
            WithdrawSuccessScreen withdrawSuccessScreen = new WithdrawSuccessScreen();
            withdrawSuccessScreen.LabelSelection(2);
            withdrawSuccessScreen.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
