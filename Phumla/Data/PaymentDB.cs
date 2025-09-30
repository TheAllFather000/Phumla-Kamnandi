using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla.Business;

namespace Phumla.Data
{
    public class PaymentDB:DB
    {
        private Collection<Payment> payments;
        public const string table = "Payment";
        public Collection<Payment> Payments
        { get { return payments; } }


        public PaymentDB()
        { 
            payments = new Collection<Payment>();
            Fill("SELECT * FROM Payment", table);
        }

        public void getAllPayments()
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                Payment p = new Payment();
                p.GuestID = Convert.ToInt64(r["guestid"]);
                p.PaymentID = Convert.ToInt64(r["paymentid"]);
                p.Amount = Convert.ToDouble(r["amount"]);
                p.Reason = Convert.ToString(r["reason"]);
                p.Date = Convert.ToString(r["date"]);
                p.Time = Convert.ToString(r["time"]);
                payments.Add(p);
            }
        }

        public bool addNewPayment(Payment p)
        {
            payments.Add(p);
            bool success = UpdateDataSource("SELECT * FROM Payment", table);
            getAllPayments();
            return success;
        }
    }
}
