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
                b.CheckedIn = Convert.ToInt32(r["checkin"]) == 1 ? true : false;
                b.BookingDate = Convert.ToString(r["bookingdate"]);
                b.BookingTime = Convert.ToString(r["bookingtime"]);
                b.DepositStatus = Convert.ToInt32(r["depositstatus"]) == 1 ? true : false;
            }

        }
        public bool createNewBooking(Booking b)
        {
            DataRow r = ds.Tables[table].NewRow();
            var success = FillRow(r, b, table, Operation.Add);
            getAllBookings();
            return success;
        }
        public bool editBooking(Booking b)
        {
            bool success = false;
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["id"]) == b.ID && Convert.ToString(r["roomid"]) == b.RoomNumber)
                {
                    success = FillRow(r, b, table, Operation.Edit);
                    break;
                }
            }
            getAllBookings();
            return success;
        }
        public Collection<Booking> getAllBookingsFor(long id)
        {
            Collection<Booking> bookingsfor = new Collection<Booking>();
            foreach (Booking b in bookings)
            {
                if (b.ID == id)
                    bookingsfor.Add(b);

            }
            return bookingsfor;
        }

        public bool cancelBooking(long id, string roomid, string date)
        {
            bool success;
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["id"]) == id && Convert.ToString(r["bookingdate"]) == date && Convert.ToString(r["roomid"]) == roomid)
                {
                    r.Delete();
                    break;
                }
                
            }
            ds.Tables[table].AcceptChanges();
            ds.AcceptChanges();
            success = UpdateDataSource("Select * From Booking", table);
            getAllBookings();
            return success;
        }


    }
}