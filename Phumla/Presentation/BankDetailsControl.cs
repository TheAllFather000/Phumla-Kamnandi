using Phumla.Business;
using Phumla.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla.Presentation
{
    public partial class BankDetailsControl : UserControl
    {
        public event EventHandler GoBack;
        private Guest guest;
        private string cardNumber;
        private DateTime expiryDate;
        private int cvv;
        private long cardNumberLong;
        private bool ValidCardNumber {  get; set; }
        private bool ValidCvv { get; set; }
        private bool ValidExpiryDate { get; set; }
        public BankDetailsControl()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // Copy the guest over from the AddBookingControl
            lblCardNumberError.Visible = false;
            lblCvvError.Visible = false;
            lblExpiryDateError.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The guest will not be created.", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                GoBack?.Invoke(this, EventArgs.Empty); // Fires the event to the parent
            }
        }

        private void btnFinaliseGuestAccount_Click(object sender, EventArgs e)
        {
            // Card number, CVV, Expiry Date
            BankingDetails bankingDetails = new BankingDetails();
            ValidCardNumber = bankingDetails.isCardNumberValid(txtCardNumber.Text);
            ValidCvv = bankingDetails.isCvvValid(txtCVV.Text);
            ValidExpiryDate = bankingDetails.isCardExpired(dtpExpiryDate.Value);

            if (!ValidCardNumber)
            {
                lblCardNumberError.Visible = true;
                lblCardNumberError.Text = "Invalid Card number entered.";
            }
            else 
            { 
                lblCardNumberError.Text = "";
                cardNumberLong = (long)Convert.ToDouble(txtCardNumber.Text);

            }

            if (!ValidCvv)
            {
                lblCvvError.Visible = true;
                lblCvvError.Text = "Invalid CVV entered.";
            } else
            {
                lblCvvError.Text = "";
                int cvv = Convert.ToInt32(txtCVV.Text);
            }

            if (ValidExpiryDate) 
            {
                lblExpiryDateError.Visible = true;
                lblExpiryDateError.Text = "Card has expired.";
            } else
            {
                lblExpiryDateError.Text = "";
                DateTime expiryDate = dtpExpiryDate.Value;
            }

            // All details captured are valid.
            if (!ValidExpiryDate && ValidCvv && ValidCardNumber)
            {
                bankingDetails = new BankingDetails(guest.ID, Convert.ToString(cardNumberLong), cvv, expiryDate.ToString());
                BankingDetailsDB bankingDetailsDB = new BankingDetailsDB();
                bankingDetailsDB.AddNewBankingDetails(bankingDetails);
            }
            
        }

        private void btnGoBackToAddGuest_Click(object sender, EventArgs e)
        {

        }
    }
}
