using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Person
    {
        private string name;
        private int age;
        private string id;
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
        public string ID
        { get { return id; } set { id = value; } } 
        public string Email
            { get { return email; } set { email = value; } }
        public string Phone
            { get { return phone; } set { phone = value; } }

        public Address Address
            { get { return address; } set { address = value; } }

        public Person(string name, int age, string id, string email, string phone)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.email = email;
            this.phone = phone;
            address = new Address();
        }

        public Person(string name, int age, string id, string email, string phone, Address ad)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.email = email;
            this.phone = phone;
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
        public Person()
        { }
        
    }
}
