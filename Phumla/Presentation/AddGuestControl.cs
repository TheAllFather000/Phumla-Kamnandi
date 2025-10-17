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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla.Presentation
{
    public partial class AddGuestControl : UserControl
    {
        private int Age { get; set; }
        private Guest guest;
        private Address address;
        private string PostalCode { get; set; }
        private DateTime dateOfBirth;
        private const int ID_AGE = 16;
        private const bool TESTING = true; // For Debugging
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
        public string StreetNumber { get; set; }

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
        public bool ValidStreetNumber { get; set; }
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

        /*
         * Determines if the adress fields are empty or not.
         */
        private bool addressFieldsEntered()
        {
            return (string.IsNullOrEmpty(StreetName) && string.IsNullOrEmpty(Suburb) &&
                    string.IsNullOrEmpty(City) && string.IsNullOrEmpty(PostalCode)
                    && string.IsNullOrEmpty(StreetNumber));
        }


        private void btnFinaliseGuestAccount_Click(object sender, EventArgs e)
        {
            FirstName = txtName.Text;
            Surname = txtSurname.Text;
            ID = txtID.Text;
            Email = txtEmail.Text;
            PhoneNumber = txtPhoneNumber.Text;
            guest = null;


            ValidID = true; // True by default to evade the condition at the bottom
            ValidName = ValidSurname = ValidEmail = ValidDOB = ValidPhoneNumber = false;

            // Name
            if (!guest.isNameValid(FirstName))
            {
                lblNameError.Text = "Enter a valid name.";
                ValidName = false;
            }
            else { 
                lblNameError.Visible = false;
                ValidName = true;
            }

            // Surname
            if (!guest.isSurnameValid(FirstName))
            {
                lblSurnameError.Text = "Enter a valid surname.";
                ValidSurname = false;
            }
            else
            {
                lblSurnameError.Visible = false;
                ValidSurname = true;
            }

            // DOB
            if (!guest.isDoBValid(dateOfBirth))
            {
                // lblDoBError.Text = "You missed everything bro";
                lblDoBError.Text = "Enter a valid date.";
                ValidDOB = false;
            }
            else
            {
                lblDoBError.Visible = false;
                Age = DateTime.Today.Year - dateOfBirth.Year;
                ValidDOB = true;
            }

            // ID

            if (guest.isIDValid(ID))
            {
                lblIDError.Text = "Enter a valid ID.";
                ValidID = false;
            }

            else
            {
                lblIDError.Visible = false;
                ValidID = true;
            }
            
            // Email
            if (!guest.isEmailValid(Email))
            {
                lblEmailError.Text = "Enter a valid email.";
                ValidEmail = false;

            }
            else
            {
                lblEmailError.Visible = false;
                ValidEmail = true;
            }

            // Phone number
            if (!guest.isPhoneValid(PhoneNumber))
            {
                lblPhoneNumberError.Text = "Enter a valid phone number.";
                ValidPhoneNumber = false;
            }
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
            StreetNumber = txtStreetNumber.Text;
            address = null;

            if (!addressFieldsEntered())
            {
                // Street Number
                if (address.isAddressValid(StreetNumber))
                {
                    lblStreetNumberError.Text = "Enter a valid country.";
                    ValidStreetNumber = false;
                }

                else
                {
                    lblStreetNumberError.Visible = false;
                    ValidStreetNumber = true;

                }
                // Street Name
                if (address.isAddressValid(StreetName))
                {
                    lblStreetNameError.Text = "Enter a valid street name.";
                    ValidStreetName = false;
                }
                else
                {
                    lblStreetNameError.Visible = false;
                    ValidStreetName = true;
                }

                // Suburb
                if (address.isAddressValid(Suburb))
                {
                    lblSuburbError.Text = "Enter a valid suburb.";
                    ValidSuburb = false;
                }
                else
                {
                    lblSuburbError.Visible = false;
                    ValidSuburb = true;
                }

                // City
                if (address.isAddressValid(City))
                {
                    lblCityError.Text = "Enter a valid city.";
                    ValidCity = false;
                }
                else
                {
                    lblCityError.Visible = false;
                    ValidCity = true;
                }

                // Postal Code
                if (address.isAddressValid(PostalCode))
                {
                    lblPostalCodeError.Text = "Enter a valid postal number.";
                    ValidPostalCode = false;
                }
                else
                {

                    lblPostalCodeError.Visible = false;
                    ValidPostalCode = true;

                }
            }

            //Console.WriteLine(ValidName + "\n" + ValidSurname + "\n" + ValidEmail + "\n" + ValidDOB + "\n" + ValidID + "\n" + ValidPhoneNumber);

            if (ValidName && ValidSurname && ValidEmail && ValidDOB && ValidID && ValidPhoneNumber)
            {
                Guest newGuest = new Guest(FirstName + " " + Surname, Age, ID, Email, PhoneNumber, 0); // 0 by default
                guestDB.AddGuest(newGuest);
                MessageBox.Show("Guest successfully added to database.");
                
            }
            if (ValidStreetName && ValidSuburb && ValidPostalCode && ValidCity && ValidStreetNumber)
            {
                Address newAddress = new Address(ID, StreetNumber, StreetName, Suburb, City, PostalCode);
                addressDB.addNewAddress(newAddress);
                MessageBox.Show("Address successfully added to database.");

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

        private void btnAddBankingDetails_Click(object sender, EventArgs e)
        {
            FirstName = txtName.Text;
            Surname = txtSurname.Text;
            ID = txtID.Text;
            Email = txtEmail.Text;
            PhoneNumber = txtPhoneNumber.Text;
            guest = null;


            ValidID = true; // True by default to evade the condition at the bottom
            ValidName = ValidSurname = ValidEmail = ValidDOB = ValidPhoneNumber = false;

            // Name
            if (!guest.isNameValid(FirstName))
            {
                lblNameError.Text = "Enter a valid name.";
                ValidName = false;
            }
            else
            {
                lblNameError.Visible = false;
                ValidName = true;
            }

            // Surname
            if (!guest.isSurnameValid(FirstName))
            {
                lblSurnameError.Text = "Enter a valid surname.";
                ValidSurname = false;
            }
            else
            {
                lblSurnameError.Visible = false;
                ValidSurname = true;
            }

            // DOB
            if (!guest.isDoBValid(dateOfBirth))
            {
                // lblDoBError.Text = "You missed everything bro";
                lblDoBError.Text = "Enter a valid date.";
                ValidDOB = false;
            }
            else
            {
                lblDoBError.Visible = false;
                Age = DateTime.Today.Year - dateOfBirth.Year;
                ValidDOB = true;
            }

            // ID

            if (guest.isIDValid(ID))
            {
                lblIDError.Text = "Enter a valid ID.";
                ValidID = false;
            }

            else
            {
                lblIDError.Visible = false;
                ValidID = true;
            }

            // Email
            if (!guest.isEmailValid(Email))
            {
                lblEmailError.Text = "Enter a valid email.";
                ValidEmail = false;

            }
            else
            {
                lblEmailError.Visible = false;
                ValidEmail = true;
            }

            // Phone number
            if (!guest.isPhoneValid(PhoneNumber))
            {
                lblPhoneNumberError.Text = "Enter a valid phone number.";
                ValidPhoneNumber = false;
            }
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
            StreetNumber = txtStreetNumber.Text;
            address = null;

            if (!addressFieldsEntered())
            {
                // Street Number
                if (address.isAddressValid(StreetNumber))
                {
                    lblStreetNumberError.Text = "Enter a valid country.";
                    ValidStreetNumber = false;
                }

                else
                {
                    lblStreetNumberError.Visible = false;
                    ValidStreetNumber = true;

                }
                // Street Name
                if (address.isAddressValid(StreetName))
                {
                    lblStreetNameError.Text = "Enter a valid street name.";
                    ValidStreetName = false;
                }
                else
                {
                    lblStreetNameError.Visible = false;
                    ValidStreetName = true;
                }

                // Suburb
                if (address.isAddressValid(Suburb))
                {
                    lblSuburbError.Text = "Enter a valid suburb.";
                    ValidSuburb = false;
                }
                else
                {
                    lblSuburbError.Visible = false;
                    ValidSuburb = true;
                }

                // City
                if (address.isAddressValid(City))
                {
                    lblCityError.Text = "Enter a valid city.";
                    ValidCity = false;
                }
                else
                {
                    lblCityError.Visible = false;
                    ValidCity = true;
                }

                // Postal Code
                if (address.isAddressValid(PostalCode))
                {
                    lblPostalCodeError.Text = "Enter a valid postal number.";
                    ValidPostalCode = false;
                }
                else
                {

                    lblPostalCodeError.Visible = false;
                    ValidPostalCode = true;

                }
            }

            //Console.WriteLine(ValidName + "\n" + ValidSurname + "\n" + ValidEmail + "\n" + ValidDOB + "\n" + ValidID + "\n" + ValidPhoneNumber);

            Guest newGuest = new Guest();
            if (ValidName && ValidSurname && ValidEmail && ValidDOB && ValidID && ValidPhoneNumber)
            {
                newGuest = new Guest(FirstName + " " + Surname, Age, ID, Email, PhoneNumber, 0); // 0 by default
                guestDB.AddGuest(newGuest);
                MessageBox.Show("Guest successfully added to database.");

            }
            if (ValidStreetName && ValidSuburb && ValidPostalCode && ValidCity && ValidStreetNumber)
            {
                Address newAddress = new Address(ID, StreetNumber, StreetName, Suburb, City, PostalCode);
                addressDB.addNewAddress(newAddress);
                MessageBox.Show("Address successfully added to database.");
            }
            if (ValidName && ValidSurname && ValidEmail && ValidDOB && ValidID && ValidPhoneNumber && ValidStreetName && ValidSuburb && ValidPostalCode && ValidCity && ValidStreetNumber)
            {
                BankDetailsControl nextControl = new BankDetailsControl(newGuest);
                nextControl.Dock = DockStyle.Fill;
                Control parentContainer = this.Parent;
                parentContainer.Controls.Remove(this);
                parentContainer.Controls.Add(nextControl);
            }

        }
    }
}
