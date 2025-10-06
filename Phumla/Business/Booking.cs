using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Booking
    {
        private long id;
        private string hotelID;
        private bool checkedin;
        private string bookingStartDate;
        private string bookingEndDate;
        private string bookingTime;
        private string roomNumber;
        private bool depositStatus;
        private double bill;

        public long ID
        { get { return id; } set { id = value; } }

        public string HotelID
        { get { return hotelID; } set { hotelID = value; } }
        public string BookingDate
        { get { return bookingStartDate; } set { bookingStartDate = value; } }

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
        public Booking(long iD, string hotelID, bool checkin, string bookingDate, string endDate, string bookingTime, string roomNumber, bool depositStatus, double b)
        {
            ID = iD;
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
            ID = booking.ID;
            RoomNumber = booking.RoomNumber;
            HotelID= booking.HotelID;
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
