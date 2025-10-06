using Phumla.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Data
{
    public class PaymentDB : DB
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
            payments.Clear();
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
            DataRow r = ds.Tables[table].NewRow();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            bool success = FillRow(r, p, table, DB.Operation.Add);
            ds.Tables[table].Rows.Add(r);
            getAllPayments();
            return success;
        }
        public bool updatePayment(Payment p)
        {
            bool success = false;
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["paymentid"]) == p.PaymentID)
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    success = FillRow(r, p, table, DB.Operation.Edit);
                    break;
                }
            }
            return success;

        }
        public Collection<Payment> getGuestPayments(long guestid)
        {
            Collection<Payment> guestpayments = new Collection<Payment>();
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["guestid"]) == guestid)
                {
                    Payment p = new Payment();
                    p.PaymentID = Convert.ToInt64(r["paymentid"]);
                    p.GuestID = Convert.ToInt64(r["guestid"]);
                    p.Time = Convert.ToString(r["time"]);
                    p.Reason = Convert.ToString(r["reason"]);
                    p.Date = Convert.ToString(r["date"]);
                    guestpayments.Add(p);
                }
            }
            return guestpayments;
        }
        public void removeAllGuestPayments(long guestid)
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["guestid"]) == guestid)
                {
                    r.Delete();

                }
            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            UpdateDataSource("SELECT * FROM Payment", table);
            getAllPayments();

        }
        public Collection<Payment> getPaymentsWithReason(string reason)
        {
            Collection<Payment> paymentsfor = new Collection<Payment>();
            foreach (Payment p in payments)
            {
                if (p.Reason == reason)
                {
                    paymentsfor.Add(p);
                }
            }
            return paymentsfor;

        }
        //theres no more obvious way to explain what this method does.
        public Collection<Payment> getGuestWhoPaidDeposit()
        {
            Collection<Payment> payment = new Collection<Payment>();
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToString(r["reason"]) == "Deposit")
                {
                    Payment p = new Payment();
                    p.PaymentID = Convert.ToInt64(r["paymentid"]);
                    p.GuestID = Convert.ToInt64(r["guestid"]);
                    p.Time = Convert.ToString(r["time"]);
                    p.Reason = Convert.ToString(r["reason"]);
                    p.Date = Convert.ToString(r["date"]);
                    payment.Add(p);
                }
                
            }
            return payment;
        }
        public bool checkDepositPayed(long id)
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["guestid"]) == id && Convert.ToString(r["reason"]) == "Deposit"
                    && Convert.ToDouble(r["amount"]) >=0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
