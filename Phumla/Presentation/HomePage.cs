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
        private const string tpgAddBookingString = "tpgAddBooking";
        private const string tpgEditBookingString = "tpgEditBooking";
        private const string tpgDeleteBookingString = "tpgDeleteBooking";
        private const string tpgSearchBookingString = "tpgSearchBooking";
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

        /*
         * Clears all tabs that don't match the tab name.
         */
        public void clearTabs(string tabName)
        {
            if (tbcHomePage.TabPages.Count == 0)
            {
                return;
            }

            for (int i = tbcHomePage.TabPages.Count - 1; i >= 0; i--)
            {
                TabPage page = tbcHomePage.TabPages[i];
                if (page.Name != tabName)
                {
                    tbcHomePage.TabPages.RemoveAt(i);
                }
            }
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

                AddBookingControl addBooking = new AddBookingControl();
                addBooking.Dock = DockStyle.Fill;
                page.Controls.Clear();
                page.Controls.Add(addBooking);
                clearTabs(tpgAddBookingString);

            }
            else if (tbcHomePage.TabPages.ContainsKey(tpgAddBookingString))
            {
                clearTabs(tpgAddBookingString);
                if (tbcHomePage.SelectedTab.Name == tpgAddBookingString) { 
                DialogResult result = MessageBox.Show("The Add Booking tab will reload.", "Are you sure?", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    TabPage existingPage = tbcHomePage.TabPages[tpgAddBookingString];
                    existingPage.Controls.Clear();
                    AddBookingControl addBooking = new AddBookingControl();
                    addBooking.Dock = DockStyle.Fill;
                    existingPage.Controls.Add(addBooking);
                    tbcHomePage.SelectedTab = existingPage;
                }
            }
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
                clearTabs(tpgEditBookingString);
            }
            else if (tbcHomePage.TabPages.ContainsKey(tpgEditBookingString))
            {
                clearTabs(tpgEditBookingString);
                if (tbcHomePage.SelectedTab.Name == tpgEditBookingString)
                {
                    DialogResult result = MessageBox.Show("The Edit Booking tab will reload.", "Are you sure?", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        TabPage existingPage = tbcHomePage.TabPages[tpgEditBookingString];
                        existingPage.Controls.Clear();
                        EditBookingControl editBooking = new EditBookingControl();
                        editBooking.Dock = DockStyle.Fill;
                        existingPage.Controls.Add(editBooking);
                        tbcHomePage.SelectedTab = existingPage;
                    }
                }
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
                clearTabs(tpgDeleteBookingString);
            }
            else if (tbcHomePage.TabPages.ContainsKey(tpgDeleteBookingString))
            {
                clearTabs(tpgDeleteBookingString);
                if (tbcHomePage.SelectedTab.Name == tpgDeleteBookingString)
                {
                    DialogResult result = MessageBox.Show("The Delete Booking tab will reload.", "Are you sure?", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        TabPage existingPage = tbcHomePage.TabPages[tpgDeleteBookingString];
                        existingPage.Controls.Clear();
                        DeleteBookingControl deleteBooking = new DeleteBookingControl();
                        deleteBooking.Dock = DockStyle.Fill;
                        existingPage.Controls.Add(deleteBooking);
                        tbcHomePage.SelectedTab = existingPage;
                    }
                }
            }
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //lblWelcome.Text = "Welcome, " + employee.EmployeeID; 
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
            this.Hide();
            new CreateReport().Show();
        }

        private void tbcHomePage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            if (!tbcHomePage.TabPages.ContainsKey(tpgSearchBookingString))
            {
                TabPage page = new TabPage();
                page.Name = tpgSearchBookingString;
                page.Text = "Search Booking";
                page.AutoScroll = true;
                tbcHomePage.Controls.Add(page);

                SearchBookingControl searchBooking = new SearchBookingControl();
                page.Controls.Clear();
                page.Controls.Add(searchBooking);
                clearTabs(tpgSearchBookingString);
            }
            else if (tbcHomePage.TabPages.ContainsKey(tpgSearchBookingString))
            {
                clearTabs(tpgSearchBookingString);
                if (tbcHomePage.SelectedTab.Name == tpgSearchBookingString)
                {
                    DialogResult result = MessageBox.Show("The Search Booking tab will reload.", "Are you sure?", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        TabPage existingPage = tbcHomePage.TabPages[tpgSearchBookingString];
                        existingPage.Controls.Clear();
                        SearchBookingControl searchBooking = new SearchBookingControl();
                        searchBooking.Dock = DockStyle.Fill;
                        existingPage.Controls.Add(searchBooking);
                        tbcHomePage.SelectedTab = existingPage;
                    }
                }
            }
        }
    }
}
