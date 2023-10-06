using ATM;
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
    public partial class CustomWithdrawScreen : Form
    {
        public CustomWithdrawScreen()
        {
            InitializeComponent();
        }

        private void CustomWithdrawlValueButton_Click(object sender, EventArgs e)
        {
            try
            {
                int customWithdrwalValue = Int32.Parse(CustomWithdrawlValueTextLabel.Text);
                WithdrawScreen withdrawScreen = new WithdrawScreen();
                if (withdrawScreen.enoughFunds(customWithdrwalValue))
                {
                    withdrawScreen.payout();
                }
                else if (!withdrawScreen.enoughFunds(customWithdrwalValue))
                {
                    withdrawScreen.notEnoughFundsWindow();
                }
                else
                {
                    withdrawScreen.errorOccurred();
                }
            }
            catch (Exception)
            {
                IncorrectValueLabel.Visible = true;
            }
            
        }
    }
}
