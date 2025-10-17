using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Booking
    {
        private int hotelID;
        private string guestid;
        private int bookingid;
        private bool checkedin;
        private string bookingStartDate;
        private string bookingEndDate;
        private string bookingTime;
        private string roomNumber;
        private bool depositStatus;
        private double bill;

        public int BookingID
        { get { return bookingid; } set { bookingid = value; } }
        public int HotelID
        { get { return hotelID; } set { hotelID = value; } }
        public string BookingDate
        { get { return bookingStartDate; } set { bookingStartDate = value; } }
        public string GuestID
        { get { return guestid; } set { guestid = value; } }
        public string BookingEnd
        { get { return bookingEndDate; }  set { bookingEndDate = value; } }
        public string BookingTime
        { get { return bookingTime; } set { bookingTime = value; } }
        public string RoomNumber
        { get { return roomNumber; } set { roomNumber = value; } }
        public bool CheckedIn
        { get { return checkedin; } set { checkedin = value; } }
        public bool DepositStatus
        { get { return depositStatus; } set { depositStatus = value; } }

        public double Bill
        { get { return bill; } set { bill = value; } }
        public Booking(int bookingid, int hotelID, string gid, bool checkin, string bookingDate, string endDate, string bookingTime, string roomNumber, bool depositStatus, double b)
        {
            this.bookingid = bookingid;
            HotelID = hotelID;
            CheckedIn = checkin;
            BookingDate = bookingDate;
            guestid = gid;
            BookingEnd = endDate;
            BookingTime = bookingTime;
            RoomNumber = roomNumber;
            DepositStatus = depositStatus;
            bill = b;
        }

        /*
         * The one used since the ID autoincrements in the DB
         */
        public Booking(string guestID, int hotelID, bool checkin, string bookingDate, string endDate, string bookingTime, string roomNumber, bool depositStatus, double b)
        {
            GuestID = guestID;
            HotelID = hotelID;
            CheckedIn = checkin;
            BookingDate = bookingDate;
            BookingEnd = endDate;
            BookingTime = bookingTime;
            RoomNumber = roomNumber;
            DepositStatus = depositStatus;
            bill = b;
        }
        public Booking(Booking booking)
        {
            this.bookingid = booking.bookingid;
            HotelID = booking.HotelID;
            this.guestid = booking.guestid;
            checkedin  = booking.CheckedIn;
            BookingTime= booking.BookingTime;
            BookingEnd = booking.BookingEnd;
            BookingDate = booking.BookingDate;
            RoomNumber = booking.RoomNumber;
            DepositStatus = booking.depositStatus;
            Bill = booking.bill;
        }
        public void incrementBill(double a)
        {
            bill += a;
        }
        public void decrementBill(double a)
        {
            bill -= a;
        }
        public Booking()
        { }

        
    }
}
