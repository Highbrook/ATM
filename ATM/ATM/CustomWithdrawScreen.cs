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
                WithdrawScreen withdrawScreen = WithdrawScreen.GetInstance;
                int responseValue = withdrawScreen.CustomEnoughFunds(customWithdrwalValue);
                if (responseValue == 0)
                {
                    withdrawScreen.payout();
                    this.DialogResult = DialogResult.OK;
                }
                else if (responseValue == 1)
                {
                    withdrawScreen.IncorrectValueFormat();
                    this.DialogResult = DialogResult.OK;
                }
                else if (responseValue == 2)
                {
                    withdrawScreen.notEnoughFundsWindow();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    withdrawScreen.errorOccurred();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                IncorrectValueLabel.Visible = true;
            }
            
        }
    }
}
