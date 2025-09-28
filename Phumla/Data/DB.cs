using Phumla.Business;
using Phumla.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Phumla.Data
{
    //generic DB class
    public class DB
    {
        protected string s = Settings.Default.PKDatabaseConnectionString;
        protected SqlConnection connection;
        protected SqlCommand command;
        protected DataSet ds;
        protected SqlDataAdapter adapter;

        public enum Operation
        {
            Add,
            Edit,
            Delete,
            Archive
        }

        public DB()
        {
            try
            {
                connection = new SqlConnection(s);
                ds = new DataSet();

            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " Error", "Error");
                return;
            }
        }
        #region filltable
        public void Fill(string query, string table)
        {
            try
            {
                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                connection.Open();
                ds.Clear();
                adapter.Fill(ds, table);
                connection.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " Error", "Error");
            }
        }
        #endregion
        #region UpdateSource
        protected bool UpdateDataSource(string query, string table)
        {
            try
            {
                connection.Open();
                adapter.Update(ds, table);
                connection.Close();
                Fill(query, table);
                return true;
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "Error", "Error");
                return false;
            }
        }
        #endregion

        #region CRUD
        
        #endregion


        #region Collections
        public int FindRow(long id, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow row in ds.Tables[table].Rows)
            {
                myRow = row;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (id.Equals(Convert.ToInt64(ds.Tables[table].Rows[rowIndex]["id"])))
                    {
                        returnValue = rowIndex;
                    }
                    rowIndex++;
                }

            }
            return returnValue;
        }
        #endregion


        public void FillRow(DataRow row, Object g, string table, DB.Operation op)
        {
            if (op != DB.Operation.Delete)
            {
                if (g.GetType() == typeof(Guest))
                {
                    Guest guest = new Guest((Guest)g);

                    row["id"] = guest.ID;
                    row["name"] = guest.Name;
                    row["email"] = guest.Email;
                    row["age"] = guest.Age;
                    row["phone"] = guest.Phone;
                    row["outstandingpayments"] = guest.Outstanding;
                    UpdateDataSource("SELECT * FROM Guest", table);
                }
                else if (g.GetType() == typeof(Booking))
                {
                    Booking b = new Booking( (Booking)g);

                    row["id"] = b.ID;
                    row["bookingid"] = b.BookingID;
                    row["hotelid"] = b.HotelID;
                    row["bookingtime"] = b.BookingTime;
                    row["bookingdate"] = b.BookingDate;
                    row["depositstatus"] = b.DepositStatus;
                    row["bill"] = b.Bill;
                    UpdateDataSource("SELECT * FROM Booking", table);
                }
                else if (g.GetType() == typeof(BankingDetails))
                {
                    BankingDetails bd = new BankingDetails((BankingDetails)g);
                    row["id"] = bd.IDNumber;
                    row["cardNumber"] = bd.CardNumber;
                    row["cvv"] = bd.CVV;
                    row["expiryDate"] = bd.ExpiryDate;
                    UpdateDataSource("SELECT * FROM BankingDetails", table);
                }
                else if (g.GetType() == typeof(Payment))
                {
                    Payment p = new Payment((Payment) g);
                    row["paymentid"] = p.PaymentID;
                    row["guestid"] = p.GuestID;
                    row["amount"] = p.Amount;
                    row["reason"] = p.Reason;
                    row["date"] = p.Date;
                    row["time"] = p.Time;
                    UpdateDataSource("SELECT * FROM Payment", table);
                }
                else if (g.GetType() == typeof(Access))
                {
                    Access a = new Access((Access)g);
                    row["employeeid"] = a.EmployeeID;
                    row["password"] = a.Password;
                    row["accesslevel"] = a.Level;
                    UpdateDataSource("SELECT * FROM Access", table);
                }
                else if (g.GetType() == typeof(Address))
                {
                    Address a = new Address((Address) g);
                    row["id"] = a.ID;
                    row["number"] = a.HouseNumber;
                    row["street"] = a.Street;
                    row["suburb"] = a.Suburb;
                    row["city"] = a.City;
                    row["postalcode"] = a.Postalcode;
                    UpdateDataSource("SELECT * FROM Address", table);
                }
            }

            
        }
    }
}
