using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Room
    {
        private string roomid;
        private int hotelid;
        private DateTime dateavailable;
        private int status; 

        public string RoomID
        { get {return roomid; } set { roomid = value;} }

        public int HotelID
        { get { return hotelid; } set { hotelid = value; } }
        public DateTime DateAvailable
        { get { return dateavailable; } set { dateavailable = value; } }
        public int Status
        { get { return status; } set { status = value; } }
        public Room(string rid, int hid, DateTime available, int status) 
        { 
            roomid = rid;
            hotelid = hid;
            dateavailable = available;
            this.status = status;
        }
        public Room(int hid, DateTime available, int status)
        {
            hotelid = hid;
            dateavailable = available;
            this.status = status;
        }
        public Room (Room r)
        {
        roomid =r.roomid;
        status = r.status;
        dateavailable = r.dateavailable;
        hotelid = r.hotelid; 
        }
        public Room() { }
    }
}
