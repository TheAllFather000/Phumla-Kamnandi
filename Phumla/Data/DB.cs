using Phumla.Business;
using Phumla.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                MessageBox.Show("Connection Error", e.Message);
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
                MessageBox.Show(e.Message, e.StackTrace);
            }
        }
        public void closeConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        #endregion
        #region UpdateSource
        public bool UpdateDataSource(string query, string table)
        {
            try
            {
                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                try
                {
                    connection.Open();
                    adapter.Update(ds, table);
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, e.StackTrace);
                }
                Fill(query, table);
                return true;
            }
            catch (SystemException e)
            {
                MessageBox.Show("Connection Error", e.Message);
                return false;
            }
        }
        #endregion

        #region CRUD

        #endregion


        #region Collections
        public int FindRow(string id, string table)
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


        public bool FillRow(DataRow row, Object g, string table, DB.Operation op)
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
                    ds.Tables[table].Rows.Add(row);

                    
                    return UpdateDataSource("SELECT * FROM Guest", table);
                }
                else if (g.GetType() == typeof(Booking))
                {
                    Booking b = new Booking((Booking)g);

                    row["id"] = b.ID;
                    row["roomid"] = b.RoomNumber;
                    row["hotelid"] = b.HotelID;
                    b.CheckedIn = Convert.ToInt32(row["checkin"]) == 1 ? true : false;
                    row["bookingtime"] = b.BookingTime;
                    row["bookingdate"] = b.BookingDate;
                    row["depositstatus"] = b.DepositStatus;
                    row["bookingend"] = b.BookingEnd;
                    ds.Tables[table].Rows.Add(row);

                    row["bill"] = b.Bill;


                    return UpdateDataSource("SELECT * FROM Booking", table);
                }
                else if (g.GetType() == typeof(BankingDetails))
                {
                    BankingDetails bd = new BankingDetails((BankingDetails)g);
                    row["id"] = bd.IDNumber;
                    row["cardNumber"] = bd.CardNumber;
                    row["cvv"] = bd.CVV;
                    row["expiryDate"] = bd.ExpiryDate;
                    ds.Tables[table].Rows.Add(row);



                    return UpdateDataSource("SELECT * FROM BankingDetails", table);
                }
                else if (g.GetType() == typeof(Payment))
                {
                    Payment p = new Payment((Payment)g);
                    row["paymentid"] = p.PaymentID;
                    row["guestid"] = p.GuestID;
                    row["amount"] = p.Amount;
                    row["reason"] = p.Reason;
                    row["date"] = p.Date;
                    row["time"] = p.Time;
                    ds.Tables[table].Rows.Add(row);

                    ;

                    return UpdateDataSource("SELECT * FROM Payment", table);
                }
                else if (g.GetType() == typeof(Employee))
                {
                    Employee a = new Employee((Employee)g);
                    row["employeeid"] = a.EmployeeID;
                    row["password_"] = a.Password;
                    row["accesslevel"] = a.Level;
                    Console.WriteLine(row["employeeid"]);
                    ds.Tables[table].Rows.Add(row);



                    return UpdateDataSource("SELECT * FROM Employee", table);
                }
                else if (g.GetType() == typeof(Address))
                {
                    Address a = new Address((Address)g);
                    row["id"] = a.ID;
                    row["number"] = a.HouseNumber;
                    row["street"] = a.Street;
                    row["suburb"] = a.Suburb;
                    row["city"] = a.City;
                    row["postalcode"] = a.Postalcode;
                    ds.Tables[table].Rows.Add(row);

                    ;

                    return UpdateDataSource("SELECT * FROM Address", table);
                }
                else if (g.GetType() == typeof(Room))
                {
                    Room r = new Room((Room)g);
                    row["roomid"] = r.RoomID;
                    row["hotelid"] = r.HotelID;
                    string d = Convert.ToString(row["date_under_use"]);
                    d.Replace("/", "-");
                    d.Replace("AM", "");
                    d.Replace("PM", "");
                    d.Trim();
                    string[] datetime = d.Split(' ');
                    int year = Convert.ToInt32(d[0]);
                    int month = Convert.ToInt32(d[1]);
                    int day = Convert.ToInt32(d[2]);
                    int hour = Convert.ToInt32(d[3]);
                    int minute = Convert.ToInt32(d[4]);
                    int second = Convert.ToInt32(d[5]);
                    r.DateAvailable = new DateTime
                        (
                        year, month, day,
                        hour, minute, second
                        );
                    ds.Tables[table].Rows.Add(row);
                    ;
                    return UpdateDataSource("SELECT * FROM ROOM", table);
                }
            }
            return false;


        }

        public void createTable(string createcommand)
        {
            SqlCommand comm = new SqlCommand(createcommand, connection);
            try
            {
                connection.Open();
                comm.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: ", ex.Message); 
            }
        }
    }
}
