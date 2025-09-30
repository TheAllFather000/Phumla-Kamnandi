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
    public partial class LoginPage : Form
    {
        public Access employee; // Will be used to show names in labels and whatnot
        public LoginPage()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        /*
         *  Will fix later - Makolela
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tempID = txtEmpID.Text;
            string password = txtPassword.Text;

            /*if (long.TryParse(tempID, out long id))
            {
        
                long empID = long.Parse(txtEmpID.Text);
                AccessDB accessDB = new AccessDB();
                Access.AccessLevel accessLevel = accessDB.checkLoginDetails(empID, password); // Causes errors.
                if (accessLevel == Access.AccessLevel.None)
                {
                    lblLoginError.Visible = true;
                    lblLoginError.Text = "Incorrect employee credentials. Please try again.";
                } else
                {
                    // Create an employee object
                }
            } */
            HomePage homePage =  new HomePage(tempID); // MODIFY WHEN CODE ABOVE WORKS
            this.Hide();
            homePage.ShowDialog();
            this.Close();

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            lblLoginError.Visible = false;          // Error message not displayed on load.
            this.CenterToScreen();
        }
    }
}
