using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Payment
    {
        private long paymentid;
        private long guestid;
        private double amount;
        private string reason;
        private string date;
        private string time;

        public long PaymentID
        {  get { return paymentid; } set { paymentid = value; } }
        public string Time
            { get { return time; } set { time = value; } }
        public string Reason
            { get { return reason; } set { reason = value; } }
        public string Date
            { get { return date; } set {    date = value; } }
        public double Amount
        { get { return amount; } set { amount = value; } }

        public long GuestID
            { get { return guestid; } set { guestid = value; } }

        public Payment(long pid, long gid, double a, string r, string d, string t)
        {
            paymentid = pid;
            guestid = gid;
            amount = a;
            reason = r;
            date = d;
            time = t;
        }

        public Payment(long gid, double amount, string reason, string date, string time)
        {
            guestid = gid;
            this.amount = amount;
            this.reason = reason;
            this.date = date;
            this.time = time;
        }
        public Payment(Payment p)
        {
            paymentid = p.paymentid;
            guestid = p.guestid;
            amount = p.amount;
            reason = p.reason;
            date = p.date;
            time = p.time;

        }
        public Payment() { }
    }
}
