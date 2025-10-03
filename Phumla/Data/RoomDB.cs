using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla.Business;
using System.Data;
using Microsoft.SqlServer.Server;
using System.Runtime.InteropServices;
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
                room.RoomID = Convert.ToString(r["roomid"]);
                room.HotelID = Convert.ToInt32(r["hotelid"]);
                string d = Convert.ToString(r["date_under_use"]);
                d.Replace("/", "-");
                d.Replace("AM", "");
                d.Replace("PM", "");
                d.Trim();
                string[] datetime = d.Split(' ');
                int year = Convert.ToInt32(d[0]);
                int month = Convert.ToInt32(d[1]);
                int day = Convert.ToInt32(d[2]);
                int hour = Convert.ToInt32(d[3]);
                int minute = Convert.ToInt32(d[4]);
                int second = Convert.ToInt32(d[5]);
                room.DateAvailable = new DateTime
                    (
                    year, month, day,
                    hour, minute, second
                    );
                Console.WriteLine(room.DateAvailable.ToString("yyyy-MM-dd HH:mm:ss"));
                rooms.Add(room);
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
        public Collection<Room> getAllAvailableRooms(DateTime date)
        {
            Collection<Room> collection = new Collection<Room>();
            Fill("SELECT * FROM Room where date_under_use <= '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "'", table);
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                Room room = new Room();
                room.RoomID = Convert.ToString(r["roomid"]);
                room.HotelID = Convert.ToInt32(r["hotelid"]);
                string d = Convert.ToString(r["date_under_use"]);
                d.Replace("/", "-");
                d.Replace("AM", "");
                d.Replace("PM", "");
                d.Trim();
                string[] datetime = d.Split(' ');
                int year = Convert.ToInt32(d[0]);
                int month = Convert.ToInt32(d[1]);
                int day = Convert.ToInt32(d[2]);
                int hour = Convert.ToInt32(d[3]);
                int minute = Convert.ToInt32(d[4]);
                int second = Convert.ToInt32(d[5]);
                room.DateAvailable = new DateTime
                    (
                    year, month, day,
                    hour, minute, second
                    );
                Console.WriteLine(room.DateAvailable.ToString("yyyy-MM-dd HH:mm:ss"));
                collection.Add(room);
            }
            return collection;
            
        }
    }
}
