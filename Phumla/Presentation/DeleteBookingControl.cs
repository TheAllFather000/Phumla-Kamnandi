﻿using Phumla.Business;
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
    public partial class DeleteBookingControl : UserControl
    {
        private BookingDB bookingDB;
        private Collection <Booking> bookings;
        public DeleteBookingControl()
        {
            InitializeComponent();
            bookingDB = new BookingDB();
            bookings = bookingDB.Bookings;
        }

        private void DeleteBookingControl_Load(object sender, EventArgs e)
        {
            // Populating the list view
            loadListView();

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
                ListViewItem item = new ListViewItem(booking.ID);
                item.SubItems.Add(booking.HotelID);
                item.SubItems.Add(booking.RoomNumber);
                item.SubItems.Add(booking.BookingDate);
                item.SubItems.Add(booking.BookingEnd);
                item.SubItems.Add(booking.CheckedIn.ToString());
                item.SubItems.Add(booking.DepositStatus.ToString());
                item.SubItems.Add(booking.Bill.ToString("$"));
                item.Tag = booking;
                lsvBookings.Items.Add(item);
            }

        }

        private void lsvBookings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (lsvBookings.SelectedItems.Count > 0)
            {
                Booking booking = lsvBookings.SelectedItems[0].Tag as Booking;
                DialogResult result = MessageBox.Show("Booking " + booking.ID + " will be permanently deleted.", "Proceed with cancellation?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bookingDB.cancelBooking(booking);
                        Email email = new Email();
                        email.Delete(, booking); // Ask Ibrahim to update the booking class
                        MessageBox.Show("Booking cancelled successfully. A notification has been sent to the guest.");
                    }
                    catch { MessageBox.Show("An error occured while atttempting to delete the record. Try again.", "ERROR"); }
                }
            }
        }
    }
}
