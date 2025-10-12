using Microsoft.VisualBasic;
using Phumla.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla.Business
{
    /*
     * The purpose of this class is to populate the hotel with rooms.
     */
    internal class Populator
    {
        HotelDB hotelDB;
        Collection<Hotel> hotels;
        RoomDB roomDB;
        Collection<Room> rooms;

        public Populator() 
        { 
            hotelDB = new HotelDB();
            hotels = hotelDB.Hotels;
            roomDB = new RoomDB();
            rooms = roomDB.Rooms;
            populateHotels();
        }

        public void populateHotels()
        {
            try
            {
                foreach(Hotel hotel in hotels)
                {
                    //Room room = new Room(false,);
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
