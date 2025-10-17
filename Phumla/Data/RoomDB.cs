using Microsoft.Office.Interop.Excel;
using Microsoft.SqlServer.Server;
using Phumla.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Phumla.Data
{
    public class RoomDB : DB
    {
        private Collection<Room> rooms;
        public static string table = "Room";
        public Collection<Room> Rooms
        {
            get { return rooms; }
            set { rooms = new Collection<Room>(value); }
        }
        public RoomDB() : base()
        {
            Fill("SELECT * FROM Room", table);
            rooms = new Collection<Room>();
            getAllRooms();
        }

        public void getAllRooms()
        {
            rooms.Clear();
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                Room room = new Room();
                room.RoomID = Convert.ToInt32(r["roomid"]);
                room.HotelID = Convert.ToInt32(r["hotelid"]);
                room.DateAvailable = Convert.ToDateTime(r["date_available"]);
                Console.WriteLine(room.DateAvailable.ToString("yyyy-MM-dd HH:mm:ss"));
                rooms.Add(room);
            }
        }
        public void setToBooked(int rid)
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (rid == (int) r["roomid"])
                {
                    r["roomstatus"] = 1;
                    break;
                }
            }
            
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, table);
            UpdateDataSource("SELECT * FROM Room", table);
            getAllRooms();

        }

        public void AddRoom(Room room)
        {
            DataRow r = ds.Tables[table].NewRow();
            FillRow(r, room, table, Operation.Add);
            getAllRooms();

        }

        public string generateRoomID()
        {
            int max = 0;
            foreach (DataRow row in ds.Tables[table].Rows)
            {
                string roomID = Convert.ToString(row["roomid"]);
                if (int.TryParse(roomID, out int currentID))
                {
                    max = Math.Max(max, currentID);
                }
            }
            return (max + 1).ToString();
        }

        public Collection<Room> checkRoomAvailability(DateTime date)
        {
            Collection<Room> collection = new Collection<Room>();
            Fill("SELECT * FROM Room where date_available <= '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "'", table);
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                Room room = new Room();
                room.RoomID = Convert.ToInt32(r["roomid"]);
                room.HotelID = Convert.ToInt32(r["hotelid"]);
                room.DateAvailable = Convert.ToDateTime(r["date_available"]);
                Console.WriteLine(room.DateAvailable.ToString("yyyy-MM-dd HH:mm:ss"));
                collection.Add(room);
            }
            Fill("SELECT * FROM Room", table);
            return collection;
            
        }
    }
}
