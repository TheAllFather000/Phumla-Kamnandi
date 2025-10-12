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
        private HotelDB hotelDB;
        private  Collection<Hotel> hotels;
        private  RoomDB roomDB;

        public Populator() 
        { 
            hotelDB = new HotelDB();
            hotels = hotelDB.Hotels;
            roomDB = new RoomDB();
            populateHotels();
        }

        /*
         * Populates the hotels with rooms.
         */
        public  void populateHotels()
        {
            try
            {
                foreach(Hotel hotel in hotels)
                {
                    Console.WriteLine(hotel.HotelName);

                    Room room = new Room(1.ToString(), hotel.HotelID, DateTime.Today, 0); // Open by default. Also Room is indexed.
                    roomDB.AddRoom(room);
                   
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
