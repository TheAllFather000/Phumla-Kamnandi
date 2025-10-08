using Phumla.Business;
using Phumla.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla.Presentation
{
    public partial class AddGuest : Form
    {
        private string firstName, surname, id, email, phoneNumber;
        private int Age {  get; set; }

        //private bool isNameValid, isSurnameValid, isIDValid, isEmailValid, isPhoneNumberValid;
        private DateTime dateOfBirth;
        private const int ID_AGE = 16;
        private const bool TESTING = true; // For Debugging
        private bool validName, validSurname, validEmail, validDOB, validPhoneNumber, validID;

        public string FirstName { get; set; } 
        public string Surname { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool ValidName { get; set; }
        public bool ValidSurname { get; set; }
        public bool ValidEmail { get; set; }
        public bool ValidDOB { get; set; }
        public bool ValidPhoneNumber { get; set; }
        public bool ValidID { get; set; }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You will be returned to the Home Page.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                HomePage homePage = new HomePage();
                homePage.ShowDialog();
                this.Hide();
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

        public bool isEmailValid (string email)
        {
            return email.Contains("@");
        }

        public bool isIDValid(string id)
        {
            return dateOfBirth.ToString("yy") == id.Substring(0, 2) &&
                dateOfBirth.ToString("MM") == id.Substring(2, 2) &&
                dateOfBirth.ToString("dd") == id.Substring(4, 2) &&
                id.Length == 13;
        }

        private void btnFinaliseGuestAccount_Click(object sender, EventArgs e)
        {
            FirstName = txtName.Text;
            Surname = txtSurname.Text;
            ID = txtID.Text;
            Email = txtEmail.Text;
            PhoneNumber = txtPhoneNumber.Text;
            GuestDB guestDB = new GuestDB();
    
          
            ValidID = true; // True by default to evade the condition at the bottom
            ValidName = ValidSurname = ValidEmail =  ValidDOB = ValidPhoneNumber = false;

            // Name
            if (string.IsNullOrEmpty(FirstName))
            {
                lblNameError.Text = "Please enter a non-blank name.";
                ValidName = false;
            } 
            else if (!FirstName.All(char.IsLetter)) 
            {
                lblNameError.Text = "Please enter a valid name.";
                ValidName = false;
            } 
            else
            {
                lblNameError.Visible = false;
                ValidName = true;
            }

            // Surname
            if (string.IsNullOrEmpty(Surname))
            {
                lblSurnameError.Text = "Please enter a non-blank Surname.";
                ValidSurname = false;
            }
            else if (!Surname.All(char.IsLetter))
            {
                lblSurnameError.Text = "Please enter a valid Surname.";
                ValidSurname = false;
            }
            else
            {
                lblSurnameError.Visible = false;
                ValidSurname = true;
            }

            // DOB
            if (dateOfBirth.Date >= DateTime.Today.Date)
            {
                // lblDoBError.Text = "You missed everything bro";
                lblDoBError.Text = "Please enter a valid date.";
                ValidDOB = false;
            }
            else
            {
                lblDoBError.Visible = false;
                Age = DateTime.Today.Year - dateOfBirth.Year;
                ValidDOB = true;
            }

            // ID
            if (txtID.Enabled == true)
            {
                if (string.IsNullOrEmpty(ID))
                {
                    lblIDError.Text = "Please enter an ID.";
                    ValidID = false;
                }
                else if (!isIDValid(ID))
                {
                    lblIDError.Text = "ID is invalid (either mismatches birthday or wrong length).";
                    ValidID = false;
                } /*else if (!guestDB.checkIDExists(ID))
                {
                    lblIDError.Text = "ID already exists.";
                    ValidID = false;
                }*/

                else
                {
                    lblIDError.Visible = false;
                    ValidID = true;
                }
            }

            // Email
            if (string.IsNullOrEmpty(Email))
            {
                lblEmailError.Text = "Please enter an Email.";
                ValidEmail = false;

            } else if (!isEmailValid(Email))
            {
                lblEmailError.Text = "Please enter a valid Email.";
                ValidEmail = false;
            } else
            {
                lblEmailError.Visible = false;
                ValidEmail = true;
            }

            // Phone number
            if (string.IsNullOrEmpty(PhoneNumber))
            {
                lblPhoneNumberError.Text = "Please enter a phone number.";
                ValidPhoneNumber = false;
            }
            else if (!PhoneNumber.All(char.IsDigit)) {
                lblPhoneNumberError.Text = "Invalid phone number, contains letters/special characters.";
                ValidPhoneNumber = false;   
            }
            else if (PhoneNumber[0] != '0' || PhoneNumber.Length != 10) {
                lblPhoneNumberError.Text = "Please enter a valid phone South African phone number.";
                ValidPhoneNumber = false;
            } /*else if (!guestDB.checkPhoneNumberExists(phoneNumber))
            {
                lblPhoneNumberError.Text = "Phone number already exists.";
                ValidPhoneNumber = false;
            }*/
            else
            {
                lblPhoneNumberError.Visible = false;
                ValidPhoneNumber = true;
            }

            //Console.WriteLine(ValidName + "\n" + ValidSurname + "\n" + ValidEmail + "\n" + ValidDOB + "\n" + ValidID + "\n" + ValidPhoneNumber);

            if (ValidName = ValidSurname = ValidEmail = ValidDOB = ValidID = ValidPhoneNumber == true)
            {
                Guest guest = new Guest(FirstName + " " + Surname, Age, ID, Email, PhoneNumber, 3.0);
                guestDB.AddGuest(guest);
            }
      

        }

        
    }
}
