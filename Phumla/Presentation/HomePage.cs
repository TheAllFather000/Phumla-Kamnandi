using Phumla.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla.Presentation
{
    public partial class HomePage : Form
    {
        private Employee employee;
        private string tpgAddBookingString = "tpgAddBooking";
        private string tpgEditBookingString = "tpgEditBooking";
        private string tpgDeleteBookingString = "tpgDeleteBooking";
        public HomePage()
        {
            InitializeComponent();
  
        }

        /*
         * For display of employee ID on certain forms. 
         */
        public HomePage(Employee employee)
        { 
            InitializeComponent();
            this.employee = employee;
          
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

            if (!tbcHomePage.TabPages.ContainsKey(tpgAddBookingString))
            {
                TabPage page = new TabPage();
                page.Name = tpgAddBookingString;
                page.Text = "Add Booking";
                tbcHomePage.TabPages.Add(page);
                tbcHomePage.SelectedTab = page;

                AddBookingControl addGuest = new AddBookingControl();
                addGuest.Dock = DockStyle.Fill;
                page.Controls.Clear();
                page.Controls.Add(addGuest);
            }
            
            

        }
        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            if (!tbcHomePage.TabPages.ContainsKey(tpgEditBookingString))
            {
                TabPage page = new TabPage();
                page.Name = tpgEditBookingString;
                page.Text = "Edit Booking";
                page.AutoScroll = true;
                tbcHomePage.Controls.Add(page);
            
                EditBookingControl editBooking = new EditBookingControl();
                page.Controls.Clear();
                page.Controls.Add(editBooking);
            }
        }
        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (!tbcHomePage.TabPages.ContainsKey(tpgDeleteBookingString))
            {
                TabPage page = new TabPage();
                page.Name = tpgDeleteBookingString;
                page.Text = "Delete Booking";
                page.AutoScroll = true;
                tbcHomePage.Controls.Add(page);

                DeleteBookingControl deleteBooking = new DeleteBookingControl();
                page.Controls.Clear();
                page.Controls.Add(deleteBooking);
            }
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

        private void btnCreateReport_Click_1(object sender, EventArgs e)
        {
           
        }

        private void tbcHomePage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
