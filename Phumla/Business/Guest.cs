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
            get
            {return outstandingPayments;}
            set { outstandingPayments = value; }
        }
        public Guest(string n, int a, long id, string e, string p, double op) : base(n, a, id, e, p)
        {
            outstandingPayments = op;
        }
        public Guest()
        {}
    }
}
