using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Hotel
    {
        private int id;
        private string name;
        private int numrooms;

        public int HotelID
        { get { return id; }
            set { id = value; }
        }
        public string HotelName
        {
            get { return name; }
            set { name = value; }
        }
        public int RoomNumber
        {
            get { return numrooms; }
            set { numrooms = value; }
        }

        public Hotel()
        {

        }
        public Hotel(int id, string name, int numrooms)
        {
            this.id = id;
            this.name = name;
            this.numrooms = numrooms;
        }
        public Hotel(Hotel h)
        {
            id = h.id;
            name = h.name;
            numrooms = h.numrooms;
        }

    }
}
