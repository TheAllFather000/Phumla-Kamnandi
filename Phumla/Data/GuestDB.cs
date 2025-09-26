using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla.Business;
using System.Data;
namespace Phumla.Data
{
    public class GuestDB: DB
    {
        private string table = "Guest";
        private string selectCommand = "SELECT * FROM Guest";
        private Collection<Guest> guests;

        private Collection<Guest> Guests
        {
            get
            { return guests; }
            set { guests = new Collection<Guest>(value); }
        }
        public GuestDB(): base()
        {

        }
        
        
        public void getAllGuests()
        {
            DataRow myRow = null;
            Guest guest;
            guest = new Guest();
            foreach (DataRow row in ds.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    guest.ID =  Convert.ToInt64(row["ID"].ToString().TrimEnd());
                    guest.Name = row["name"].ToString().TrimEnd();
                    guest.Age = Convert.ToInt32(row["age"].ToString().TrimEnd());
                    guest.Email = row["email"].ToString().TrimEnd();
                    guest.Phone = row["phone"].ToString().TrimEnd();
                    guest.Outstanding = Convert.ToDouble(row["outstandingpayments"]);
                    guests.Add(guest);
            }
            }
            
        }

        public void FillRow(DataRow row, Guest g)
        {
            row["ID"] = g.ID;
            row["name"] = g.Name;
            row["email"] = g.Email;
            row["age"] = g.Age;
            row["phone"] = g.Phone;
            row["outstandingpayments"] = g.Outstanding;
        }


        }

    
}
