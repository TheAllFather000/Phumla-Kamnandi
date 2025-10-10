using Phumla.Business;
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
        private Employee employee;
        private AddBooking reservation;
        public HomePage()
        {
            InitializeComponent();
            reservation = new AddBooking();
            reservation.Visible= false;
        }

        /*
         * For display of employee ID on certain forms. 
         */
        public HomePage(Employee employee)
        { 
            InitializeComponent();
            this.employee = employee;
            reservation = new AddBooking();
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
                employee = null;
            }
        }

        private void btnRemoveGuest_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage();
            page.Name = "tpgAddBooking";
            page.Text = "Add Booking";

            tbcHomePage.Controls.Add(page);

            AddBookingControl addGuest = new AddBookingControl();
            addGuest.Dock = DockStyle.Fill;
            page.Controls.Clear();
            page.Controls.Add(addGuest);

        }

        /*public void AddGuest_GoBack (object sender, EventArgs e) // JUST LIKE GDSCRIPT
        {
            tpg.Controls.Clear();
            tpg.Controls.Add(new AddGuestControl());
        }*/

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //lblHomePage.Text = "Welcome, " + employee.EmployeeID; 
        }

        private void poisonDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void poisonContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
