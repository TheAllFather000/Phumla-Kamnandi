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

        public const string summaryless= "SELECT  \r\n\r\n    hotelid,\r\n   \r\n    SUM(CASE WHEN MONTH(Payment.date) = 1 THEN amount ELSE 0 END) AS Jan, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 2 THEN amount ELSE 0 END) AS Feb, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 3 THEN amount ELSE 0 END) AS Mar, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 4 THEN amount ELSE 0 END) AS Apr, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 5 THEN amount ELSE 0 END) AS May, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 6 THEN amount ELSE 0 END) AS Jun, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 7 THEN amount ELSE 0 END) AS Jul, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 8 THEN amount ELSE 0 END) AS Aug, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 9 THEN amount ELSE 0 END) AS Sep, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 10 THEN amount ELSE 0 END) AS Oct, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 11 THEN amount ELSE 0 END) AS Nov, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 12 THEN amount ELSE 0 END) AS 'Dec', \r\n\r\n    SUM(amount) AS Total \r\n\r\nFROM Payment \r\n\r\nWHERE Payment.date <= '{0}'\r\nGROUP BY hotelid;";
        public const string summarygreater= "SELECT  \r\n\r\n    hotelid,\r\n   \r\n    SUM(CASE WHEN MONTH(Payment.date) = 1 THEN amount ELSE 0 END) AS Jan, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 2 THEN amount ELSE 0 END) AS Feb, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 3 THEN amount ELSE 0 END) AS Mar, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 4 THEN amount ELSE 0 END) AS Apr, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 5 THEN amount ELSE 0 END) AS May, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 6 THEN amount ELSE 0 END) AS Jun, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 7 THEN amount ELSE 0 END) AS Jul, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 8 THEN amount ELSE 0 END) AS Aug, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 9 THEN amount ELSE 0 END) AS Sep, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 10 THEN amount ELSE 0 END) AS Oct, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 11 THEN amount ELSE 0 END) AS Nov, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 12 THEN amount ELSE 0 END) AS 'Dec', \r\n\r\n    SUM(amount) AS Total \r\n\r\nFROM Payment \r\n\r\nWHERE Payment.date >= '{0}'\r\nGROUP BY hotelid;";
        public const string summarybetween= "SELECT  \r\n\r\n    hotelid,\r\n   \r\n    SUM(CASE WHEN MONTH(Payment.date) = 1 THEN amount ELSE 0 END) AS Jan, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 2 THEN amount ELSE 0 END) AS Feb, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 3 THEN amount ELSE 0 END) AS Mar, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 4 THEN amount ELSE 0 END) AS Apr, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 5 THEN amount ELSE 0 END) AS May, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 6 THEN amount ELSE 0 END) AS Jun, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 7 THEN amount ELSE 0 END) AS Jul, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 8 THEN amount ELSE 0 END) AS Aug, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 9 THEN amount ELSE 0 END) AS Sep, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 10 THEN amount ELSE 0 END) AS Oct, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 11 THEN amount ELSE 0 END) AS Nov, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 12 THEN amount ELSE 0 END) AS 'Dec', \r\n\r\n    SUM(amount) AS Total \r\n\r\nFROM Payment \r\n\r\nWHERE Payment.date >= '{0}' AND Payment.date <= '{1}'\r\nGROUP BY hotelid;";
        public const string summaryforyear= "SELECT  \r\n\r\n    hotelid,\r\n   \r\n    SUM(CASE WHEN MONTH(Payment.date) = 1 THEN amount ELSE 0 END) AS Jan, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 2 THEN amount ELSE 0 END) AS Feb, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 3 THEN amount ELSE 0 END) AS Mar, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 4 THEN amount ELSE 0 END) AS Apr, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 5 THEN amount ELSE 0 END) AS May, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 6 THEN amount ELSE 0 END) AS Jun, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 7 THEN amount ELSE 0 END) AS Jul, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 8 THEN amount ELSE 0 END) AS Aug, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 9 THEN amount ELSE 0 END) AS Sep, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 10 THEN amount ELSE 0 END) AS Oct, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 11 THEN amount ELSE 0 END) AS Nov, \r\n\r\n    SUM(CASE WHEN MONTH(Payment.date) = 12 THEN amount ELSE 0 END) AS 'Dec', \r\n\r\n    SUM(amount) AS Total \r\n\r\nFROM Payment \r\n\r\nWHERE YEAR(Payment.date) = {0}\r\nGROUP BY hotelid;";
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
                p.GuestID = Convert.ToString(r["guestid"]);
                p.HotelID = Convert.ToInt32(r["hotelid"]);
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
        /*public bool updatePayment(Payment p)
        {
            bool success = false;
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["paymentid"]) == p.hotelid)
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    success = FillRow(r, p, table, DB.Operation.Edit);
                    break;
                }
            }
            return success;

        }*/
        public Collection<Payment> getGuestPayments(long guestid)
        {
            Collection<Payment> guestpayments = new Collection<Payment>();
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["guestid"]) == guestid)
                {
                    Payment p = new Payment();
                    p.HotelID = Convert.ToInt32(r["hotelid"]);
                    p.GuestID = Convert.ToString(r["guestid"]);
                    p.Time = Convert.ToString(r["time"]);
                    p.Reason = Convert.ToString(r["reason"]);
                    p.Date = Convert.ToString(r["date"]);
                    guestpayments.Add(p);
                }
            }
            return guestpayments;
        }
        public Collection<Payment> getPaymentsHotel(int hotelid)
        {
            Collection<Payment> guestpayments = new Collection<Payment>();
            foreach (Payment p in payments)
            {
                if (p.HotelID == hotelid)
                {
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
                    p.HotelID = Convert.ToInt32(r["hotelid"]);
                    p.GuestID = Convert.ToString(r["guestid"]);
                    p.Time = Convert.ToString(r["time"]);
                    p.Reason = Convert.ToString(r["reason"]);
                    p.Date = Convert.ToString(r["date"]);
                    payment.Add(p);
                }
                
            }
            return payment;
        }
        public bool checkDepositPayed(string id)
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToString(r["guestid"]) == id && Convert.ToString(r["reason"]) == "Deposit"
                    && Convert.ToDouble(r["amount"]) >=0)
                {
                    return true;
                }
            }
            return false;
        }
        public void SummaryReport(string year)
        {
            string selectCommand = string.Format(summaryforyear, year);
            Fill(selectCommand, table);

        }
        public void SummaryGreater(string date)
        {
            string selectCommand = string.Format(summarygreater, date);
            Fill(selectCommand, table);

        }
        public void SummaryBetween(string date, string d2)
        {
            string selectCommand = string.Format(summarybetween, date, d2);
            Fill(selectCommand, table);

        }
        public void SummaryLess(string date)
        {
            string selectCommand = string.Format(summaryless, date);
            Fill(selectCommand, table);

        }
        public DataSet getDataSet()
        { return ds; }
        
    }

}
