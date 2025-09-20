using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Booking
    {
        private string id;
        private string bookingID;
        private string hotelID;
        private string bookingDate;
        private string bookingTime;
        private string roomNumber;
        private bool depositStatus;


        public string ID
        { get { return id; } set { id = value; } }
        public string BookingID
        { get { return bookingID; } set { bookingID = value; } }
        public string HotelID
        { get { return hotelID; } set { hotelID = value; } }
        public string BookingDate
        { get { return bookingDate; } set { bookingDate = value; } }

        public string BookingTime
        { get { return bookingTime; } set { bookingTime = value; } }
        public string RoomNumber
        { get { return roomNumber; } set { roomNumber = value; } }
        
        public bool DepositStatus
        { get { return depositStatus; } set { depositStatus = value; } }


        public Booking(string iD, string bookingID, string hotelID, string bookingDate, string bookingTime, string roomNumber, bool depositStatus)
        {
            ID = iD;
            BookingID = bookingID;
            HotelID = hotelID;
            BookingDate = bookingDate;
            BookingTime = bookingTime;
            RoomNumber = roomNumber;
            DepositStatus = depositStatus;
        }
    }
}
