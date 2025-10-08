using Phumla.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Phumla.Data
{
    public class GuestDB: DB
    {
        public const string table = "Guest";
        private Collection<Guest> guests;

        public Collection<Guest> Guests
        {
            get{ return guests; }
            set { guests = new Collection<Guest>(value); }
        }
        public GuestDB(): base()
        {
            Guests = new Collection<Guest>();
            Fill("SELECT * FROM GUESTS", table);
            getAllGuests();
        }
        
        
        public void getAllGuests()
        {
          
            Guests = new Collection<Guest>();

            foreach (DataRow row in ds.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    var guest = new Guest();
                    guest.ID =  Convert.ToString(row["id"].ToString().TrimEnd());
                    guest.Name = row["name"].ToString().TrimEnd();
                    guest.Age = Convert.ToInt32(row["age"].ToString().TrimEnd());
                    guest.Email = row["email"].ToString().TrimEnd();
                    guest.Phone = row["phone"].ToString().TrimEnd();
                    guest.Outstanding = Convert.ToDouble(row["outstandingpayments"]);
                    guests.Add(guest);
            }
            }
            
        }
        public bool AddGuest(Guest g)
        {
            DataRow r = ds.Tables[table].NewRow();
            bool success = FillRow(r, g, table, DB.Operation.Add);
            guests.Add(g);
            return success;
        }

        

        #region CRUD
        public bool DataSetChange(Guest g, DB.Operation operation)
        {
            DataRow r = null;
            switch (operation)
            {
                case DB.Operation.Add:
                    r = ds.Tables[table].NewRow();
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    FillRow(r, g, table, operation);
                    ds.Tables[table].Rows.Add(r);
                    break;
                case DB.Operation.Delete:
                    DeleteEntry(g.ID, operation);
                break;
                case DB.Operation.Edit:
                    r = ds.Tables[table].Rows[FindRow(g.ID, table)];
                    FillRow(r, g,table, operation);
                break;
                
            }
            getAllGuests();
            return UpdateDataSource("SELECT * FROM Guest", table);
        }

        public bool DeleteEntry(string id, DB.Operation op)
        {
            int rowIndex = 0;
            if (op == DB.Operation.Delete)
            {
                    foreach (DataRow row in ds.Tables[table].Rows)
                    {
                        if (id == Convert.ToString(ds.Tables[table].Rows[rowIndex]["id"]) && rowIndex < ds.Tables[table].Rows.Count)
                        {
                            ds.Tables[table].Rows.Remove(row);
                            break;
                        }
                        rowIndex++;

                    }

            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            bool success = UpdateDataSource("SELECT * FROM Guest", table);
            getAllGuests();
            return success;
        }
        #endregion


        #region Collections
        
        #endregion


        #region Build, Insert & Create, Update Commands
        private void Build_INSERT_Parameters(Guest g)
        {
            SqlParameter param = default(SqlParameter);
            param.SourceVersion = DataRowVersion.Current;
            param = new SqlParameter("@id", SqlDbType.BigInt, 100, "ID");
            adapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@name", SqlDbType.Text, 100, "Name");
            adapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@age", SqlDbType.Int, 2, "Age");
            adapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@email", SqlDbType.Text, 100, "Email");
            adapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NChar, 20, "Phone");
            adapter.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@outstandingpayments", SqlDbType.Decimal, 10, "Outstanding");
            adapter.InsertCommand.Parameters.Add(param);

        }

         private void Build_UPDATE_Parameters(Guest g)
        {
            SqlParameter param = default(SqlParameter);
            param.SourceVersion = DataRowVersion.Current;
            param = new SqlParameter("@id", SqlDbType.Text, 100, "ID");
            adapter.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@name", SqlDbType.Text, 100, "Name");
            adapter.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@age", SqlDbType.Int, 2, "Age");
            adapter.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@email", SqlDbType.Text, 100, "Email");
            adapter.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NChar, 20, "Phone");
            adapter.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@outstandingpayments", SqlDbType.Decimal, 10, "Outstanding");
            adapter.UpdateCommand.Parameters.Add(param);


        }

        public void Create_UPDATE_Command(Guest g)
        {
            adapter.UpdateCommand = new SqlCommand("UPDATE Guest SET name = @name, phone = @phone, age = @age, email = @email, outstandingpayments = @outstandingpayments WHERE ID=@ID", connection);
            Build_UPDATE_Parameters(g);
        }

        private void Create_INSERT_Command(Guest g)
        {
            adapter.InsertCommand = new SqlCommand("INSERT INTO Guest(id, name, age, email, phone, outstandingpayments) VALUES (@id, @name, @age, @email, @phone, @outstandingpayments)");
            Build_INSERT_Parameters(g);
        }

        public bool UpdateDataSource(Guest g)
        {
            Create_INSERT_Command(g);
            var success = UpdateDataSource("SELECT * FROM Guest", table);
            Create_UPDATE_Command(g);
            return success;
        }
        #endregion
        //to do , put the current methods into DB class, generalise for all classes.
    }
}
