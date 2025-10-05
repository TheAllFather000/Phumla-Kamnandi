using Phumla.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.ObjectModel;
using Phumla.Business;

namespace Phumla.Data
{

    public class AddressDB: DB
    {
        public const string table = "Address";
        private Collection<Address> addresses;

        public Collection<Address> Addresses { get { return addresses; } set { addresses = new Collection<Address>(value); } }
        public AddressDB() 
        {
            addresses = new Collection<Address>();
            Fill("SELECT * FROM Address", table);
            AllAddresses();
        }
        public void AllAddresses()
        {
            addresses = new Collection<Address>();
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                Address a = new Address();

                a.ID = Convert.ToInt64(r["id"]);
                a.HouseNumber = Convert.ToString(r["number"]);
                a.Suburb = Convert.ToString(r["suburb"]);
                a.City = Convert.ToString(r["city"]);
                a.Postalcode = Convert.ToString(r["postalcode"]);
                addresses.Add(a);
                a = new Address();
            }
        }
        public void DeleteAddress(long id)
        {
            int rowindex = 0;
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["id"]) == id)
                {
                    r.Delete();
                    ds.Tables[table].AcceptChanges();
                    ds.AcceptChanges();
                }

                rowindex++;
            }
            UpdateDataSource("SELECT * FROM Address", table);
            AllAddresses();
        }

        public Address addNewAddress(long id, string n, string s, string su, string city, string postalcode)
        {
            Address a = new Address(id, n, s, su, city, postalcode);
            Addresses.Add(a);
            DataRow r = ds.Tables[table].NewRow();
            FillRow(r, a, table, DB.Operation.Add);
            AllAddresses();
            return a;
        }
        public Address getAddress(long id)
        {
            foreach (Address add in addresses)
            {
                if (id == add.ID)
                {
                    return add;
                }

            }
            return null;
    }
}
    }
