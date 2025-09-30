using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla.Presentation
{
    public partial class AddGuest : Form
    {
        private string name, surname, id, email, phoneNumber;
        private DateTime dateOfBirth;
        private const int ID_AGE = 16;
        private const bool TESTING = true; // For Debugging
        public AddGuest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dateOfBirth = dtpDOB.Value;
            dateOfBirth = (dateOfBirth.DayOfYear <= DateTime.Today.DayOfYear) 
                ? dateOfBirth : dateOfBirth.AddYears(1); // Modifies year value to determine guest's age.
            if ((DateTime.Today.Year - dateOfBirth.Year) < ID_AGE)
            {
                lblID.Enabled = false;
                txtID.Enabled = false;
            } else
            {
                lblID.Enabled = true;
                txtID.Enabled = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddGuest_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            dtpDOB.MaxDate = DateTime.Now;
            lblID.Enabled = false;
            txtID.Enabled = false;

            if (TESTING)
            {
                clearAll(this);
            }

        }

        /*
         * Clears the text boxes on the form.
         */
        public void clearAll (Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Clear();
                }

                if (c is Label label && c.Name.Contains("Error"))
                {
                    label.Text = "";
                }

                if (c.HasChildren)
                {
                    clearAll(c);
                }
            }

        }

        private void pnlBillingAddress_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddBankingDetails_Click(object sender, EventArgs e)
        {
            BankingDetails bankingDetails = new BankingDetails();
            bankingDetails.Show();
            this.Hide();
        }

        private void btnFinaliseGuestAccount_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            surname = txtSurname.Text;
            dateOfBirth = dtpDOB.Value;
            id = txtID.Text;
            email = txtEmail.Text;
            phoneNumber = txtPhoneNumber.Text;

            // Name
            if (string.IsNullOrEmpty(name))
            {
                lblNameError.Text = "Please enter a non-blank name.";
            }

            // Surname
            if (string.IsNullOrEmpty(surname))
            {
                lblSurnameError.Text = "Please enter a non-blank surname.";

            }

            // DOB
            if (dateOfBirth.Date == DateTime.Today.Date)
            {
                // lblDoBError.Text = "You missed everything bro";
                lblDoBError.Text = "Please enter a valid date.";
            }

            // ID
            if (txtID.Enabled == true) { 
                if (string.IsNullOrEmpty(id))
                {
                    lblIDError.Text = "Please enter an ID.";
                }
            }

            // Email
            if (string.IsNullOrEmpty(email))
            {
                lblEmailError.Text = "Please enter an email.";
            }

            // Phone number
            if (string.IsNullOrEmpty(phoneNumber))
            {
                lblPhoneNumberError.Text = "Please enter a phone number.";
            }


        }

        
    }
}
