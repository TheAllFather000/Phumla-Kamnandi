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
    public partial class HomePage : Form
    {
        private string empID = "The man with hands";
        private CreateReservation reservation;
        public HomePage()
        {
            InitializeComponent();
            reservation = new CreateReservation();
            reservation.Visible= false;
        }

        /*
         * For display of employee ID on certain forms. 
         */
        public HomePage(string empID)
        { 
            InitializeComponent();
            this.empID = empID;
            reservation = new CreateReservation();
            reservation.Visible = false;
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("You will be logged out of your account.",  "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirmation == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                this.Hide();
                loginPage.ShowDialog();
                this.Close();
            }
        }

        private void btnRemoveGuest_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            reservation.Visible = true;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lblHomePage.Text = "Welcome, " + "[EMPLOYEE NAME]"; // CHANGE FOR LATER
        }
    }
}
