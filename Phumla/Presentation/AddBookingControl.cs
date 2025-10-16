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
        private Collection<Guest> bookingGuests; // The guests in the booking itself.
        private Collection<Booking> bookings;
        private Collection<Hotel> hotels;
        private PaymentDB paymentDB;
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
        private void AddBookingControl_Load(object sender, EventArgs e)
        {
            guestDB = new GuestDB();
            hotelDB = new HotelDB();
            bookingDB = new BookingDB();
            paymentDB = new PaymentDB();
            guests = guestDB.Guests; // Guests is now populated
            hotels = hotelDB.Hotels; // Hotels too.
            bookingGuests = new Collection<Guest>();

            cbxHotels.Items.Clear();
            foreach (Hotel hotel in hotels)
            { 
                cbxHotels.Items.Add(hotel.HotelID + " - " + hotel.HotelName);
            }

            dtpEndDate.MinDate = dtpStartDate.MinDate = DateTime.Today;


            lblGuest1Status.Text = "";

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
            Control parentFlp = ptb.Parent;
            char index = ptb.Name.Last();
            Control[] found = parentFlp.Controls.Find("lblGuest" + index + "Status", false);
            Label guestStatus = null;
            if (found.Length > 0)
            {
                guestStatus = found[0] as Label;
            }

            if (guestStatus == null) return;

            guestStatus.ForeColor = SystemColors.ControlText;
            guestStatus.Font = new System.Drawing.Font(guestStatus.Font, System.Drawing.FontStyle.Regular);

            bool guestFound = false;

            if (ptb.Text.Length >= 13)
            {
                foreach (Guest guest in guests)
                {
                    if (ptb.Text == guest.ID)
                    {
                        guestStatus.Text = "Guest found: " + guest.Name;
                        guestStatus.ForeColor = System.Drawing.Color.Green;

                        if (!bookingGuests.Contains(guest))
                        {
                            bookingGuests.Add(guest);
                        }
                        guestFound = true;
                        break;
                    }
                }

                if (!guestFound)
                {
                    guestStatus.Text = "Guest not found. Create new guest?";
                    guestStatus.ForeColor = System.Drawing.Color.Red;
                    guestStatus.Font = new System.Drawing.Font(
                        guestStatus.Font,
                        guestStatus.Font.Style | System.Drawing.FontStyle.Underline);
                }

            }
            else if (ptb.Text.Length > 0)
            {
                guestStatus.Text = "ID too short...";
                guestStatus.ForeColor = System.Drawing.Color.Orange;
                guestStatus.Font = new System.Drawing.Font(guestStatus.Font, System.Drawing.FontStyle.Regular);
            }
            else
            {
                guestStatus.Text = "";
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

        private int daysBetween ()
        {
            double days = (dtpEndDate.Value - dtpStartDate.Value).TotalDays;
            return (int)days;
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            GuestsValid = true; // Assume true by default
            searchStatuses(flpAddGuests);
            // First confirm all the information has been entered
            if (GuestsValid && !string.IsNullOrEmpty(cbxHotels.Text)) 
            {
                DialogResult result = MessageBox.Show("Finished with the guest's details?", "Finalise Booking", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //booking
                    int hotelID = Convert.ToInt32(cbxHotels.Text.Substring(0, cbxHotels.Text.IndexOf("-")));
                    int availableRoom = Convert.ToInt32(hotelDB.roomsAvailable(hotelID, true)[0].RoomID);
                    Booking booking = new Booking(bookingGuests[0].ID, hotelID.ToString(), 
                        false, dtpStartDate.Value.ToString(), dtpEndDate.Value.ToString(), 
                        dtpStartDate.Value.TimeOfDay.ToString(), availableRoom.ToString(), true, Price.calculateDays(dtpStartDate.Value, dtpEndDate.Value)) ;
                    bookingDB.createNewBooking(booking);

                    Payment payment = new Payment((long) Convert.ToDouble(bookingGuests[0].ID), Price.calculateDeposit(dtpStartDate.Value, dtpEndDate.Value),
                        "Deposit", DateTime.Now.Date.ToString(), DateTime.Now.TimeOfDay.ToString());
                    paymentDB.addNewPayment(payment);
                    // The first parameter is a goddamn problem. Why the hell is it a long

                    new Email(bookingGuests[0], booking, 1, hotelID.ToString()).sendBookingMail();
                }
            }

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;  // This prevent's me from having to have validation for the date
            txtSummary.Text = ToString();
        }

        private string ToString ()
        {
            string temp = "Summary:\nHotel:\t" + cbxHotels.Text + "\nGuests:\t";
            foreach (Guest guest in bookingGuests)
            {
                temp += "\t" + guest.ID + "\n";
            }
            temp += "Total days:\t" + daysBetween() + "\n";
            temp += "Total cost (not incl. deposit):\t" + Price.calculateDays(dtpStartDate.Value, dtpEndDate.Value);
            return temp;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            txtSummary.Text = ToString();

        }
    }
} 

