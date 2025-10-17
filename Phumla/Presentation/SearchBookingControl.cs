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
    public partial class SearchBookingControl : UserControl
    {
        private BookingDB bookingDB;
        private Collection<Booking> bookings;
        public SearchBookingControl()
        {
            InitializeComponent();
            bookingDB = new BookingDB();
            bookings = bookingDB.Bookings;
        }

        private void loadListView()
        {
            lsvBookings.Clear();
            // Populating the list view
            lsvBookings.View = View.Details;
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

                ListViewItem item = new ListViewItem(Convert.ToString(booking.BookingID));
                item.SubItems.Add(Convert.ToString(booking.GuestID));
                item.SubItems.Add(Convert.ToString(booking.HotelID));
                item.SubItems.Add(booking.RoomNumber);
                item.SubItems.Add(booking.BookingDate);
                item.SubItems.Add(booking.BookingEnd);
                item.SubItems.Add(booking.CheckedIn.ToString());
                item.SubItems.Add(booking.DepositStatus.ToString());
                item.SubItems.Add(booking.Bill.ToString());
                item.Tag = booking;
                lsvBookings.Items.Add(item);
            }

        }


        private void SearchBooking_Load(object sender, EventArgs e)
        {
            loadListView();

        }
        private int daysBetween(DateTime start, DateTime end)
        {
            double days = (end - start).TotalDays;
            return (int)days;
        }
        private string ToString(Booking booking)
        {
            string temp = "Summary:\nHotel:\t" + booking.HotelID + "\nGuests:\t";

            temp += "\t" + booking.GuestID + "\n";
            
            temp += "Total days:\t" + daysBetween(Convert.ToDateTime(booking.BookingEnd), Convert.ToDateTime(booking.BookingDate)) + "\n";
            temp += "Bill: " + booking.Bill;
            return temp;
        }

        private void lsvBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBookings.SelectedItems.Count > 0)
            {
                Booking booking = lsvBookings.SelectedItems[0].Tag as Booking;
                txtSummary.Text = ToString(booking);
            }
        }
    }
}
