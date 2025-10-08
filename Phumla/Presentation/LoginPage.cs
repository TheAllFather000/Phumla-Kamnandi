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
        private Employee employee; // Carried over to other forms
        private bool debug = true;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            long empID = 0;
            Int64.TryParse(txtEmpID.Text, out empID);
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(txtEmpID.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill in the text fields given.", "Invalid Login Credentials");
            }
            else
            {
                EmployeeDB employeeDB = new EmployeeDB();
                Employee.AccessLevel accessLevel = employeeDB.checkLoginDetails(empID, password);
                if (accessLevel == Employee.AccessLevel.None)
                {
                    MessageBox.Show("Login Details are incorrect. Please Try Again.", "Invalid Login Credentials");
                    txtPassword.Clear();
                }
                else
                {
                    employee = new Employee(empID, password);
                    HomePage homePage = new HomePage(employee);
                    this.Hide();
                    homePage.ShowDialog();
                    this.Close();
                }
            }
            
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            if (debug)
            {
                txtEmpID.Text = "111111";
                txtPassword.Text = "Ibrahim Was Here";
            }
            this.CenterToScreen();
        }
    }
}
