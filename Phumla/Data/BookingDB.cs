using Phumla.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Data
{
    public class BookingDB : DB
    {
        private Collection<Booking> bookings;
        public static string table = "Booking";
        public static string summaryfordate = "SELECT  \r\n\r\n    hotelid,\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 1 THEN guestid ELSE NULL END) AS Jan, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 2 THEN guestid ELSE NULL END) AS Feb, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 3 THEN guestid ELSE NULL END) AS Mar, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 4 THEN guestid ELSE NULL END) AS Apr, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 5 THEN guestid ELSE NULL END) AS May, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 6 THEN guestid ELSE NULL END) AS Jun, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 7 THEN guestid ELSE NULL END) AS Jul, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 8 THEN guestid ELSE NULL END) AS Aug, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 9 THEN guestid ELSE NULL END) AS Sep, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 10 THEN guestid ELSE NULL END) AS Oct, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 11 THEN guestid ELSE NULL END) AS Nov, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 12 THEN guestid ELSE NULL END) AS 'Dec', \r\n\r\n    COUNT(guestid) AS Total \r\n\r\nFROM Booking \r\n\r\nWHERE bookingdate <= '{0}'\r\nGROUP BY hotelid;";
        public static string summarybetween = "SELECT  \r\n\r\n    hotelid,\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 1 THEN guestid ELSE NULL END) AS Jan, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 2 THEN guestid ELSE NULL END) AS Feb, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 3 THEN guestid ELSE NULL END) AS Mar, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 4 THEN guestid ELSE NULL END) AS Apr, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 5 THEN guestid ELSE NULL END) AS May, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 6 THEN guestid ELSE NULL END) AS Jun, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 7 THEN guestid ELSE NULL END) AS Jul, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 8 THEN guestid ELSE NULL END) AS Aug, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 9 THEN guestid ELSE NULL END) AS Sep, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 10 THEN guestid ELSE NULL END) AS Oct, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 11 THEN guestid ELSE NULL END) AS Nov, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 12 THEN guestid ELSE NULL END) AS 'Dec', \r\n\r\n    COUNT(guestid) AS Total \r\n\r\nFROM Booking \r\n\r\nWHERE bookingdate >= '{0}' AND bookingend <= '{1}'\r\nGROUP BY hotelid;";
        public static string summarygreater = "SELECT  \r\n\r\n    hotelid,\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 1 THEN guestid ELSE NULL END) AS Jan, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 2 THEN guestid ELSE NULL END) AS Feb, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 3 THEN guestid ELSE NULL END) AS Mar, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 4 THEN guestid ELSE NULL END) AS Apr, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 5 THEN guestid ELSE NULL END) AS May, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 6 THEN guestid ELSE NULL END) AS Jun, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 7 THEN guestid ELSE NULL END) AS Jul, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 8 THEN guestid ELSE NULL END) AS Aug, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 9 THEN guestid ELSE NULL END) AS Sep, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 10 THEN guestid ELSE NULL END) AS Oct, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 11 THEN guestid ELSE NULL END) AS Nov, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 12 THEN guestid ELSE NULL END) AS 'Dec', \r\n\r\n    COUNT(guestid) AS Total \r\n\r\nFROM Booking \r\n\r\nWHERE bookingdate >= '{0}'\r\nGROUP BY hotelid;";
        public static string summaryall = "SELECT  \r\n\r\n    hotelid,\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 1 THEN guestid ELSE NULL END) AS Jan, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 2 THEN guestid ELSE NULL END) AS Feb, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 3 THEN guestid ELSE NULL END) AS Mar, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 4 THEN guestid ELSE NULL END) AS Apr, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 5 THEN guestid ELSE NULL END) AS May, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 6 THEN guestid ELSE NULL END) AS Jun, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 7 THEN guestid ELSE NULL END) AS Jul, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 8 THEN guestid ELSE NULL END) AS Aug, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 9 THEN guestid ELSE NULL END) AS Sep, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 10 THEN guestid ELSE NULL END) AS Oct, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 11 THEN guestid ELSE NULL END) AS Nov, \r\n\r\n    COUNT(CASE WHEN MONTH(bookingdate) = 12 THEN guestid ELSE NULL END) AS 'Dec', \r\n\r\n    COUNT(guestid) AS Total \r\n\r\nFROM Booking \r\nGROUP BY hotelid;";
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
                b.GuestID = Convert.ToString(r["guestid"]);
                b.Bill = Convert.ToDouble(r["bill"]);
                b.RoomNumber = Convert.ToString(r["roomid"]);
                b.BookingID = Convert.ToInt32(r["id"]);
                b.HotelID = Convert.ToInt32(r["hotelid"]);
                b.CheckedIn = Convert.ToInt32(r["checkin"]) == 1 ? true : false;
                b.BookingDate = Convert.ToString(r["bookingdate"]);
                b.BookingTime = Convert.ToString(r["bookingtime"]);
                b.BookingEnd = Convert.ToString(r["bookingend"]);
                b.DepositStatus = Convert.ToInt32(r["depositstatus"]) == 1 ? true : false;
                bookings.Add(b);
            }

        }
        public bool createNewBooking(Booking b)
        {
            DataRow r = ds.Tables[table].NewRow();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var success = FillRow(r, b, table, Operation.Add);
            getAllBookings();
            return success;
        }
        public bool editBooking(Booking b)
        {
            bool success = false;
            foreach (DataRow r in ds.Tables[table].Rows)
            {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                if (Convert.ToString(r["id"]) == b.GuestID && Convert.ToString(r["roomid"]) == b.RoomNumber)
=======
                if (Convert.ToInt32(r["id"]) == b.BookingID && Convert.ToString(r["roomid"]) == b.RoomNumber)
>>>>>>> Stashed changes
=======
                if (Convert.ToInt32(r["id"]) == b.BookingID && Convert.ToString(r["roomid"]) == b.RoomNumber)
>>>>>>> Stashed changes
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    success = FillRow(r, b, table, Operation.Edit);
                    break;
                }
            }
            getAllBookings();
            return success;
        }
        public Collection<Booking> getAllBookingsFor(string id)
        {
            Collection<Booking> bookingsfor = new Collection<Booking>();
            foreach (Booking b in bookings)
            {
                if (b.BookingID.ToString() == id)
                    bookingsfor.Add(b);

            }
            return bookingsfor;
        }

        public bool cancelBooking(string id, string roomid, string date)
        {
            bool success;
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToString(r["id"]) == id && Convert.ToString(r["bookingdate"]) == date && Convert.ToString(r["roomid"]) == roomid)
                {
                    r.Delete();
                    break;
                }
                
            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            success = UpdateDataSource("Select * From Booking", table);
            getAllBookings();
            return success;
        }
        public bool cancelBooking(Booking booking)
        {
            bool success;
            foreach (DataRow r in ds.Tables[table].Rows)
            {

                if (Convert.ToString(r["id"]) == Convert.ToString(booking.BookingID) && Convert.ToString(r["bookingdate"]) == booking.BookingDate && Convert.ToString(r["roomid"]) == booking.RoomNumber)

                {
                    r.Delete();
                    break;
                }

            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            success = UpdateDataSource("Select * From Booking", table);
            getAllBookings();
            return success;
        }

        public DataSet getDataSet()
        {
            return ds;
        }

        public void occupancyForAll()
        {
            Fill(summaryall, table);
        }
        
        public void occupancyForLess(string date)
        {
            string select = string.Format(summaryfordate, date);
            Fill(select, table);
        }

        public void occupancyBetween (string d1, string d2)
        {
            string select = string.Format(summarybetween, d1, d2);
            Fill(select, table);
        }
        public void occupancyGreater (string d1)
        {
            string select = string.Format(summarygreater, d1);
            Fill(select, table);
        }
        

    }
}