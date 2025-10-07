using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Address
    {
        private long id;
        private string number;
        private string street;
        private string suburb;
        private string city;
        private string postalcode;

        public string HouseNumber
        { get { return number; } set { number = value; } }
        
        public long ID
        { get { return id; } set { id = value; } }
        
        public string Street
        {
            get { return street; }
            set {  street = value; }
        }

        public string Suburb
        { get { return suburb; } set { suburb = value; } }

        
        public string City
        { get { return city; } set { city = value; } }

        public string Postalcode
            { get { return postalcode; } set { postalcode = value; } }


        public Address()
        {
            number = street = suburb = city = postalcode = "NONE";
        }

        public Address(long id, string num, string street, string suburb, string city, string pc)
        {
            this.id = id;
            number = num;
            this.street = street;
            this.suburb = suburb;
            this.city = city;
            postalcode = pc;
        }

        public Address(Address address)
        {
            this.id = address.id;
            number = address.number;
            street = address.street;
            suburb = address.suburb;
            city = address.city;
            postalcode = address.postalcode;

        }


        public override string ToString()
        {
            return number + " " + street+", " + suburb + ", " + city + ", " + postalcode;
        }

        public string FormalToString()
        {
            return "ID: " + id + "\nHouse Number: " + number + "\nStreet: " + street + "\nSuburb: " + 
                suburb + "\nCity: " + city + "\nPostal Code: " + postalcode;
        }


    }
}
