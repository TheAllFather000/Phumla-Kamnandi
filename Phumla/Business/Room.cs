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
        private int status; 

        public string RoomID
        { get {return roomid; } set { roomid = value;} }

        public int HotelID
        { get { return hotelid; } set {  hotelid = value;}  }
        
        public int Status
        { get { return status; } set { status = value; } }
        public Room(string rid, int hid, int status) 
        { 
            roomid = rid;
            hotelid = hid;
            this.status = status;
        }
        public Room (Room r)
        {
        roomid =r.roomid;
        status = r.status;
        hotelid = r.hotelid; 
        }
        public Room() { }
    }
}
