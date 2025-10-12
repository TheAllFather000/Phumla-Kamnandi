using Phumla.Business;
using Phumla.Data;
using Phumla.Properties;
using ReaLTaiizor.Child.Metro;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Crown;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml.Serialization;

namespace Phumla.Presentation
{
    public partial class AddBookingControl : UserControl
    {
        private const int GUEST_MAX = 4;
        private int guestCount = 1;
        private GuestDB guestDB;
        private BookingDB bookingDB;
        private HotelDB hotelDB;
        private Collection<Guest> guests;
        private Collection<Booking> bookings;
        private Collection<Hotel> hotels;
        private string connectionString = Settings.Default.PKDatabaseConnectionString;
        private bool GuestsValid {  get; set; }
        private bool DatesValid { get; set; }
        private bool RoomAvailable {  get; set; }
        public AddBookingControl()
        {
            InitializeComponent();
        }

        private void lblAddBooking_Click(object sender, EventArgs e)
        {

        }

        /*       private void cyberButton1_Click(object sender, EventArgs e)
               {
                   flowLayoutPanel1.Controls.Add(new Label());
                   flowLayoutPanel1.Controls.Add(new TextBox());
                   flowLayoutPanel1.Controls.Add(cyberButton1);
               }*/

        /*private void DisplayGuests()
        {
            lsvGuests.Items.Clear();

            foreach (Guest guest in guests)
            {
                ListViewItem listViewItem = new ListViewItem(guest.ID);
                listViewItem.SubItems.Add(guest.Name);
                listViewItem.SubItems.Add(guest.Age.ToString());
                listViewItem.SubItems.Add(guest.Outstanding.ToString());
                lsvGuests.Items.Add(listViewItem);
            }
        }*/

        private void AddBookingControl_Load(object sender, EventArgs e)
        {
            guestDB = new GuestDB();
            hotelDB = new HotelDB();
            guests = guestDB.Guests; // Guests is now populated
            hotels = hotelDB.Hotels; // Hotels too.

            cbxHotels.Items.Clear();
            foreach (Hotel hotel in hotels)
            { 
                cbxHotels.Items.Add(hotel.HotelID + " - " + hotel.HotelName);
            }

            dtpEndDate.MinDate = dtpStartDate.MinDate = DateTime.Today;


            lblGuest1Status.Text = "";
            /*lsvGuests.View = View.Details;
            lsvGuests.Columns.Add("d", 20, HorizontalAlignment.Left);
            lsvGuests.Columns.Add("r", 20, HorizontalAlignment.Left);
            lsvGuests.Columns.Add("e", 20, HorizontalAlignment.Left);
            lsvGuests.Columns.Add("g", 20, HorizontalAlignment.Left);
            DisplayGuests();*/
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {

            if (guestCount < GUEST_MAX)
            {
                guestCount++;

                // Essentially a copy of flpGuest1
                FlowLayoutPanel newFLP = new FlowLayoutPanel();
                newFLP.Name = "flpGuest" + guestCount;
                newFLP.Size = flpGuest1.Size;

                Label lblGuest = new Label();
                lblGuest.Name = "lblGuest" + guestCount;
                lblGuest.Text = "Guest ID:";
                lblGuest.Size = lblGuest1.Size;
                lblGuest.Anchor = lblGuest1.Anchor;

                PoisonTextBox txtID = new PoisonTextBox();
                txtID.Name = "txtGuest" + guestCount;
                txtID.Size = txtGuest1.Size;
                txtID.Margin = new Padding(0);
                txtID.TextChanged += txtGuest_TextChanged; // Attaching generic event

                Label lblGuestStatus = new Label();
                lblGuestStatus.Name = "lblGuest" + guestCount + "Status";
                lblGuestStatus.Text = "";
                lblGuestStatus.Size = lblGuest1Status.Size;
                lblGuest1Status.Width = 25;
                lblGuestStatus.Anchor = lblGuest1Status.Anchor;
                lblGuestStatus.Click += lblGuestStatus_Clicked;

                newFLP.Controls.Add(lblGuest);
                newFLP.Controls.Add(txtID);
                newFLP.Controls.Add(lblGuestStatus);

                // Add to UserControl
                flpAddGuests.Controls.Add(newFLP);
                flpAddGuests.Controls.Add(flpGuestButtons);
                //MessageBox.Show(guestCount.ToString());
            }

            if (guestCount > 1)
            {
                btnRemoveGuest.Visible = true;
            }

            if (guestCount == GUEST_MAX)
            {
                btnAddGuest.Enabled = false;
            } else
            {
                btnAddGuest.Enabled = true;
            }


        }

        private void lsvGuests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flpAddGuests_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemoveGuest_Click(object sender, EventArgs e)
        {
            btnAddGuest.Enabled = true;

            if (guestCount > 1)
            {
               
                Control flp = flpAddGuests.Controls["flpGuest" + (guestCount)];
                flpAddGuests.Controls.Remove(flp);
                guestCount--;
                //MessageBox.Show(guestCount.ToString());

            }

            if (guestCount == 1)
            {
                btnRemoveGuest.Visible = false;
            } else
            {
                btnRemoveGuest.Visible = true;
            }
        }

        private void skyComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGuest1_Click(object sender, EventArgs e)
        {
            
        }

        /*  Might come back to recode the monstrosity below
         *  - Makolela
         */
        private void lblGuestStatus_Clicked (object sender, EventArgs e)
        {
            Label status = sender as Label;
            MetroTabControl tabControl = status.Parent.Parent.Parent.Parent.Parent as MetroTabControl;
            int index = Convert.ToInt32(status.Name[8].ToString()); // Position of the number in the label
            
            foreach (System.Windows.Forms.TabPage page in tabControl.TabPages)
            {
                if (page.Name.Contains(Convert.ToString(index)))
                {
                    return;
                }
            }

            if (status.Text == "Guest not found. Create new guest?") 
            {
                MetroTabPage createGuestPage = new MetroTabPage();
                createGuestPage.Name = "Guest#" + index;
                createGuestPage.AutoScroll = true;
                createGuestPage.Text = "Create Guest #" + index; 
                tabControl.Controls.Add(createGuestPage);

                AddGuestControl guestPage = new AddGuestControl();
                createGuestPage.Controls.Add(guestPage);
                tabControl.SelectedTab = createGuestPage;
            }
        }

        private void txtGuest_TextChanged(object sender, EventArgs e)
        {
            PoisonTextBox ptb = sender as PoisonTextBox;
            Label guestStatus = null;
            char index = ptb.Name.Last();
            Control[] found = flpAddGuests.Controls.Find("lblGuest" + Convert.ToString(index) + "Status", true);

            if (found.Length > 0)
            {
                guestStatus = found[0] as Label;
            }

            if (guestStatus == null) return; // AAAHHHHHH

            foreach (Guest guest in guests)
            {
                //MessageBox.Show(guest.ID);
                if (ptb.Text == guest.ID && !string.IsNullOrEmpty(txtGuest1.Text))
                {
                    guestStatus.Text = "Guest found.";
                    break;
                }
                else if (string.IsNullOrEmpty(txtGuest1.Text)) {
                    guestStatus.Text = "";
                }
                else 
                {
                    guestStatus.Text = "Guest not found. Create new guest?";
                    // Make it Underlined
                }
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Details entered will be removed.", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
            {
                
            }
        }
        private void searchStatuses (Control ctrl) {
            foreach (Control child in ctrl.Controls)
            {
                if (child.Name.EndsWith("Status")) 
                {
                    Label label = (Label) child; 
                    if (label.Text.Contains("Guest not found. Create new guest?"))
                    {
                        GuestsValid = false;
                        break;
                    }
                }

                if (ctrl.HasChildren)
                {
                    searchStatuses(child);
                }

            }
        }

        private void isDatesValid()
        {
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                MessageBox.Show("End date value cannot be before Start date value.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DatesValid = false;
                return;
            }
            DatesValid = true;

        }
        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            searchStatuses(flpAddGuests);
            isDatesValid();
            // First confirm all the information has been entered
            if (GuestsValid  && DatesValid) 
            {
                DialogResult result = MessageBox.Show("Finished with the guest's details?", "Finalise Booking", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //booking
                }
            }

        }
    }
} 

