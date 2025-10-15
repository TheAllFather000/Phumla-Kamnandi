using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Payment
    {
        private int hotelid;
        private long guestid;
        private double amount;
        private string reason;
        private string date;
        private string time;

        public int HotelID
        {  get { return hotelid; } set { hotelid = value; } }
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

        public Payment(int hid, long gid, double a, string r, string d, string t)
        {
            hotelid = hid;
            guestid = gid;
            amount = a;
            reason = r;
            date = d;
            time = t;
        }
        public Payment(Payment p)
        {
            hotelid = p.hotelid;
            guestid = p.guestid;
            amount = p.amount;
            reason = p.reason;
            date = p.date;
            time = p.time;

        }
        public Payment() { }
    }
}
