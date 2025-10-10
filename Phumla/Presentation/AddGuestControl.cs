using Phumla.Business;
using Phumla.Data;
using ReaLTaiizor.Child.Metro;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Crown;
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
    public partial class AddGuestControl : UserControl
    {
        /*  private string firstName, surname, id, email, phoneNumber;
         *  private string streetName, suburb, city, country;
         *  private int postalCode;
        */
        private int Age { get; set; }
        private string PostalCode { get; set; }

        //private bool isNameValid, isSurnameValid, isIDValid, isEmailValid, isPhoneNumberValid;
        private DateTime dateOfBirth;
        private const int ID_AGE = 16;
        private const bool TESTING = true; // For Debugging
        /*private bool validName, validSurname, validEmail, validDOB, validPhoneNumber, validID;
        private bool validStreetName, validSuburb, validCity, validCountry, validPostalCode;*/
        GuestDB guestDB = new GuestDB();
        AddressDB addressDB = new AddressDB();

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public bool ValidName { get; set; }
        public bool ValidSurname { get; set; }
        public bool ValidEmail { get; set; }
        public bool ValidDOB { get; set; }
        public bool ValidPhoneNumber { get; set; }
        public bool ValidID { get; set; }
        bool ValidStreetName { get; set; }
        bool ValidSuburb { get; set; }
        bool ValidPostalCode { get; set; }
        public bool ValidCity { get; set; }
        public bool ValidCountry { get; set; }
        public AddGuestControl()
        {
            InitializeComponent();
        }

        private void AddGuestControl_Load(object sender, EventArgs e)
        {
            clearAll(this);
        }

        /*
      * Clears the text boxes on the form.
      */
        public void clearAll(Control parent)
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


        public bool isEmailValid(string email)
        {
            return email.Contains("@");
        }

        public bool isIDValid(string id)
        {
            return dateOfBirth.ToString("yy") == id.Substring(0, 2) &&
                dateOfBirth.ToString("MM") == id.Substring(2, 2) &&
                dateOfBirth.ToString("dd") == id.Substring(4, 2) &&
                id.Length == 13 &&
                id.All(char.IsDigit);
        }

        private void btnFinaliseGuestAccount_Click(object sender, EventArgs e)
        {
            FirstName = txtName.Text;
            Surname = txtSurname.Text;
            ID = txtID.Text;
            Email = txtEmail.Text;
            PhoneNumber = txtPhoneNumber.Text;


            ValidID = true; // True by default to evade the condition at the bottom
            ValidName = ValidSurname = ValidEmail = ValidDOB = ValidPhoneNumber = false;

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

            }
            else if (!isEmailValid(Email))
            {
                lblEmailError.Text = "Please enter a valid Email.";
                ValidEmail = false;
            }
            else
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
            else if (!PhoneNumber.All(char.IsDigit))
            {
                lblPhoneNumberError.Text = "Invalid phone number, contains letters/special characters.";
                ValidPhoneNumber = false;
            }
            else if (PhoneNumber[0] != '0' || PhoneNumber.Length != 10)
            {
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

            // Now the addresses
            StreetName = txtStreetName.Text;
            Suburb = txtSuburb.Text;
            City = txtCity.Text;
            PostalCode = txtPostalCode.Text;
            Country = txtCountry.Text;

            // Street Name
            if (string.IsNullOrEmpty(StreetName))
            {
                lblStreetNameError.Text = "Please enter a street name.";
                ValidStreetName = false;
            }
            else
            {
                lblStreetNameError.Visible = false;
                ValidStreetName = true;
            }

            // Suburb
            if (string.IsNullOrEmpty(Suburb))
            {
                lblSuburbError.Text = "Please enter a suburb.";
                ValidSuburb = false;
            }
            else
            {
                lblSuburbError.Visible = false;
                ValidSuburb = true;
            }

            // City
            if (string.IsNullOrEmpty(City))
            {
                lblCityError.Text = "Please enter a city.";
                ValidCity = false;
            }
            else
            {
                lblCityError.Visible = false;
                ValidCity = true;
            }

            // Postal Code
            if (string.IsNullOrEmpty(PostalCode))
            {
                lblPostalCodeError.Text = "Please enter a postal number.";
                ValidPostalCode = false;
            }
            else
            {
                if (!txtPostalCode.Text.All(char.IsDigit))
                {
                    lblPostalCodeError.Text = "Please enter a valid postal code.";
                    ValidPostalCode = false;
                }
                else
                {
                    lblPostalCodeError.Visible = false;
                    ValidPostalCode = true;
                }
            }

            // Country
            if (string.IsNullOrEmpty(StreetName))
            {
                lblCountryError.Text = "Please enter a country.";
                ValidCountry = false;
            }

            else
            {
                lblCountryError.Visible = false;
                ValidCountry = true;

            }

            //Console.WriteLine(ValidName + "\n" + ValidSurname + "\n" + ValidEmail + "\n" + ValidDOB + "\n" + ValidID + "\n" + ValidPhoneNumber);

            if (ValidName = ValidSurname = ValidEmail = ValidDOB = ValidID = ValidPhoneNumber
                = ValidStreetName = ValidSuburb = ValidPostalCode = ValidCity = ValidCountry == true)
            {
                Guest guest = new Guest(FirstName + " " + Surname, Age, ID, Email, PhoneNumber, 3.0);
                guestDB.AddGuest(guest);
                Address address = new Address(ID, "4", StreetName, Suburb, City, PostalCode); // I'll say 0 for now, but street nr is unnecessary
                addressDB.addNewAddress(address);
                MessageBox.Show("Guest successfully added to database.");
            }

        }

        /*
         * Finds the parent of a given control by searching for the type of parent.
         */
        public Control findParent(Control control, Type type)
        {
            while (control != null)
            {
                if (control.GetType() == type) {
                    Console.WriteLine("Parent found :D " + control.Name);
                    return control;
                }
                control = control.Parent;
            }
            Console.WriteLine("Parent not found :[");
            return null;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            DialogResult result = MessageBox.Show("Creation will be cancelled.", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MetroTabControl tabControl = (MetroTabControl) findParent(this, typeof(MetroTabControl));
                MetroTabPage page = (MetroTabPage) findParent(this, typeof(MetroTabPage));

                Console.WriteLine(tabControl.GetType().Name);
                Console.WriteLine(page.GetType().Name);

                if (tabControl == null || page == null)
                {
                    return;
                }

                if (tabControl.TabPages.Contains(page))
                {
                    int index = tabControl.TabPages.IndexOf(page);
                    Console.WriteLine(index);
                    tabControl.SelectedTab = tabControl.TabPages[0]; // The Add Guests page
                    tabControl.TabPages.Remove(page);
                }

                /*foreach (System.Windows.Forms.TabPage page in tabControl.TabPages)
                {
                    Console.WriteLine(page.Name);

                }*/

            } else
            {
                btnCancel.Enabled = true;
            }
        }
    }
}
