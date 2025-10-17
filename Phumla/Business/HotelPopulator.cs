﻿using Microsoft.VisualBasic;
using Phumla.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Phumla.Business
{
    /*
     * The purpose of this class is to populate the hotel with rooms.
     */
    internal class HotelPopulator
    {
        private HotelDB hotelDB;
        private  Collection<Hotel> hotels;
        private  RoomDB roomDB;

        public HotelPopulator() 
        { 
            hotelDB = new HotelDB();
            hotels = hotelDB.Hotels;
            roomDB = new RoomDB();
        }

        /*
         * Populates the hotels with rooms.
         */
        public  void populateHotels()
        {
            try
            {
                foreach (Hotel hotel in hotels)
                {
                    for (int i = 0; i < hotel.RoomNumber; i++)
                    {
                        Room room = new Room
                        {
                            HotelID = hotel.HotelID,
                            DateAvailable = DateTime.Today,
                            Status = 0
                        };

                        roomDB.AddRoom(room);
                    }
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
