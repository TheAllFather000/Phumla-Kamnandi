using Phumla.Business;
using Phumla.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla.Presentation
{
    public partial class EditBookingControl : UserControl
    {
        private BookingDB bookingDB;
        private Collection<Booking> bookings;
        private string BookingID {  get; set; }
        private string HotelID { get; set; }
        private bool CheckedIn {  get; set; }
        private string StartDate { get; set; }
        private string EndDate { get; set; }
        private string RoomNumber { get; set; }
        private bool DepositStatus { get; set; }
        private double Bill { get; set; }
        public EditBookingControl()
        {
            InitializeComponent();
            bookingDB = new BookingDB();
            bookings = bookingDB.Bookings;
            loadListView();

        }

        public void changeEnabled(Control parent, bool enable)
        {
            foreach (Control c in parent.Controls)
            {
                c.Enabled = enable;

                if (c.HasChildren)
                {
                    changeEnabled(c, enable);
                }
            }

        }

        private void loadListView()
        {
            lsvBookings.Clear();
            lsvBookings.View = View.Details;
            lsvBookings.Columns.Clear();
            lsvBookings.Columns.Add("BookingID", 100, HorizontalAlignment.Left);
            lsvBookings.Columns.Add("HotelID", 100, HorizontalAlignment.Left);
            lsvBookings.Columns.Add("RoomID", 100, HorizontalAlignment.Left);
            lsvBookings.Columns.Add("Start Date", 100, HorizontalAlignment.Left);
            lsvBookings.Columns.Add("End Date", 100, HorizontalAlignment.Left);
            lsvBookings.Columns.Add("Checked In", 100, HorizontalAlignment.Left);
            lsvBookings.Columns.Add("Deposit Status", 100, HorizontalAlignment.Left);
            lsvBookings.Columns.Add("Bill", 100, HorizontalAlignment.Left);

            foreach (Booking booking in bookings)
            {
                ListViewItem item = new ListViewItem(booking.ID);
                item.SubItems.Add(booking.HotelID);
                item.SubItems.Add(booking.RoomNumber);
                item.SubItems.Add(booking.BookingDate.ToString());
                item.SubItems.Add(booking.BookingEnd.ToString());
                item.SubItems.Add(booking.CheckedIn.ToString());
                item.SubItems.Add(booking.DepositStatus.ToString());
                item.SubItems.Add(booking.Bill.ToString("C"));

                item.Tag = booking;
                lsvBookings.Items.Add(item);
            }
        }

        private void EditBookingControl_Load(object sender, EventArgs e)
        {
            // Greying out the fields by default:
            changeEnabled(tlpBookingDetails, false);
            btnConfirmChanges.Enabled = false;
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            // We'll need to check if the modified data is valid in the first place
            BookingID = txtBookingID.Text;
            HotelID = txtHotelID.Text;
            RoomNumber = txtRoomID.Text;
            CheckedIn = cbxCheckedIn.Checked;
            StartDate = dtpStartDate.Text;
            EndDate = dtpEndDate.Text;
            DepositStatus = cbxDepositStatus.Checked;
            Bill = Convert.ToDouble(txtBill.Text);
            // Optional: 
            // Time = txtTime.Text;
            //Booking booking = new Booking(BookingID, HotelID, CheckedIn, StartDate, EndDate, "Blank", RoomNumber, DepositStatus, Bill);

            //bookingDB.editBooking(booking);
            bookings = bookingDB.Bookings;
            loadListView();

            // bookingDB.editBooking(new Booking(false, ));

        }

        private void lsvBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBookings.SelectedItems.Count > 0)
            {
                // Enables everything
                changeEnabled(tlpBookingDetails, true);
                // Add details to each component
                Booking booking = lsvBookings.SelectedItems[0].Tag as Booking;
                txtBookingID.Text = booking.ID;
                txtHotelID.Text = booking.HotelID;
                txtRoomID.Text = booking.RoomNumber;
                cbxCheckedIn.Checked = booking.CheckedIn;
                dtpStartDate.Value =  Convert.ToDateTime(booking.BookingDate);
                dtpEndDate.Value = Convert.ToDateTime(booking.BookingEnd);
                // txtDepositStatus.Text = booking.DepositStatus;
                txtBill.Text = booking.Bill.ToString("C");
            }
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            // I'll deal with you later, bum
        }

        private void txtBookingID_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (btnConfirmChanges.Enabled != true) btnConfirmChanges.Enabled = true;
            
        }
    }
}
