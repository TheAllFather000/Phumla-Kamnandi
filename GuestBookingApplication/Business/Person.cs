using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingApplication.Business
{
    public class Person
    {
        private string name;
        private int age;
        private long id;
        private string email;
        private string phone;
        private Address address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
            { get { return age; } set { age = value; } }
        public long ID
        { get { return id; } set { id = value; } } 
        public string Email
            { get { return email; } set { email = value; } }
        public string Phone
            { get { return phone; } set { phone = value; } }

        public Address Address
            { get { return address; } set { address = value; } }

        public Person(string n, int a, long id, string e, string p)
        {
            name = n;
            age = a;
            this.id = id;
            email = e;
            phone = p;
            address = new Address();
        }

        public Person(string n, int a, long id, string e, string p, Address ad)
        {
            name = n;
            age = a;
            this.id = id;
            email = e;
            phone = p;
            address = ad;
        }
        public Person(Person p)
        {
            name = p.name;
            age = p.age;
            id = p.id;
            email = p.email;
            phone = p.phone;
            address = p.address;
        }
        
    }
}
