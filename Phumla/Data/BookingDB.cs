using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla.Business;

namespace Phumla.Data
{
    public class BookingDB : DB
    {
        private Collection<Booking> bookings;
        public static string table = "Booking";

        public Collection<Booking> Bookings
        {
            get { return bookings; }
            set { bookings = value; }
        }

        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            Fill("Select * From Booking", table);
            getAllBookings();
        }
        public void getAllBookings()
        {
            bookings.Clear();
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                Booking b = new Booking();
                b.ID = Convert.ToInt64(r["id"]);
                b.Bill = Convert.ToDouble(r["bill"]);
                b.RoomNumber = Convert.ToString(r["roomid"]);
                b.HotelID = Convert.ToString(r["hotelid"]);
                b.BookingDate = Convert.ToString(r["bookingdate"]);
                b.BookingTime = Convert.ToString(r["bookingtime"]);
                b.DepositStatus = Convert.ToInt32(r["depositstatus"]) == 1 ? true : false;
            }

        }
    }

}