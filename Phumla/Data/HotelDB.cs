using Microsoft.VisualBasic;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla.Business;
using System.Data;

namespace Phumla.Data
{
    internal class HotelDB : DB
    {
        private string table = "Hotel";
        private string selectCommand = "Select * From Hotel";
        private Collection<Hotel> hotels;
        private RoomDB roomdb;

        public Collection<Hotel> Hotels
        {
            get { return hotels; }
            set { hotels = new Collection<Hotel>(value); }

        }
        public HotelDB() : base()
        {
            hotels = new Collection<Hotel>();
            roomdb = new RoomDB();
            Fill(selectCommand, table);
            fillWithHotels();
        }

        public void fillWithHotels()
        {
            hotels.Clear();
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                Hotel h = new Hotel();
                h.HotelID = Convert.ToInt32(r["hotelId"]);
                h.HotelName = Convert.ToString(r["name"]);
                h.RoomNumber = Convert.ToInt32(r["numRooms"]);
                hotels.Add(h);
            }
        }
        //rooms with a 'status' of 0 means they are not currently taken.
        //if the second param is true, we are looking for rooms with a status of 0. otherwise just collect the rooms as is.
        public Collection<Room> roomsAvailable(int hotelid, bool option)
        {
            Collection<Room> availableRooms = new Collection<Room>();
            if (option)
            {
                foreach (Room r in roomdb.Rooms)
                {
                    if (r.HotelID == hotelid && r.Status == 0)
                    {
                        availableRooms.Add(r);
                    }
                }
                return availableRooms;
            }
            else
            {
                foreach (Room r in roomdb.Rooms)
                {
                    if (r.HotelID == hotelid)
                    {
                        availableRooms.Add(r);
                    }
                }
                return availableRooms;
            }
        } 


    }

}
