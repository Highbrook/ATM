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
    public partial class PinConfirmation : Form
    {
        private int DEV_CorrectPIN = 1234;
        public PinConfirmation()
        {
            InitializeComponent();
        }

        private void InsertCardDevButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sPINValue = PinConfirmationTextBox.Text;
                int iPINValue = Int32.Parse(sPINValue); 
                if (iPINValue == DEV_CorrectPIN)
                {
                    MessageBox.Show("Correct PIN");
                }
            }
            catch (Exception)
            {
                IncorrectPinLabel.Visible = true;
            }
        }
    }
}
