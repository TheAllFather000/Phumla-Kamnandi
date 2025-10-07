using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Guest : Person
    {
        private double outstandingPayments;
        public double Outstanding
        {
            get { return outstandingPayments; }
            set { outstandingPayments = value; }
        }
        public Guest(string name, int age, string id, string email, string phone, double outstandingPayments) : base(name, age, id, email, phone)
        {
            this.outstandingPayments = outstandingPayments;
        }
        public Guest()
        {}
        public Guest(Guest g)
        {
            ID = g.ID;
            Name = g.Name;
            Phone = g.Phone;
            Email = g.Email;
            outstandingPayments = g.outstandingPayments;
            Age = g.Age;
        }
    }
}
