using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla.Business;
using System.Data;
using Microsoft.SqlServer.Server;
namespace Phumla.Data
{
    public class RoomDB:DB
    {
        private Collection<Room> rooms;
        public static string table = "RoomDB";
        public Collection<Room> Rooms
        {
            get { return rooms; }
            set { rooms = new Collection<Room>(value); }
        }
        public RoomDB(): base()
        { 
            Fill("SELECT * FROM ROOM", table);
            
        }

        public void getAllRooms()
        {
            rooms.Clear();
            foreach (DataRow r in ds.Tables[table].Rows) 
            {
                Room room = new Room();
                room.RoomID = Convert.ToString(r["roomid"]);
                room.HotelID = Convert.ToInt32(r["hotelid"]);
                room.Status = Convert.ToInt32(r["status"]);

            }
            }
        public void setToBooked(string rid)
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (rid == Convert.ToString(r["roomid"]))
                    {
                    r["roomstatus"] = 1;
                    ds.Tables[table].AcceptChanges();
                    break;
                    }
            }
            ds.AcceptChanges();
            UpdateDataSource("SELECT * FROM Room", table);
            getAllRooms();
            
        }
    }
}
