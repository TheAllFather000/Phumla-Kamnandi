using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Phumla.Business;
using System.Collections.ObjectModel;
namespace Phumla.Data
{
    public class AccessDB : DB
    {
        public static string table = "Access";
        public static string selectCommand = "SELECT * FROM Access";
        private Collection<Access> accesses;

        public Collection<Access> EmployeeAccess
        {
            get { return accesses; }
            set { accesses = value; }
        }
        public AccessDB() : base()
        {
            accesses = new Collection<Access>();
            Fill(selectCommand, table);
            fillWithAccess();
        }
        public void fillWithAccess()
        {
            if (!ds.Tables.Contains(table))
            {
                Fill("SELECT * FROM Access", "Access");
            }
            foreach (DataRow row in ds.Tables[table].Rows)
            {
                    Access a = new Access();
                    a.EmployeeID = Convert.ToInt64(row["employeeid"]);
                    a.Password = Convert.ToString(row["password_"]);
                    switch (Convert.ToString(row["accesslevel"]))
                    {
                        case "Receptionist":
                            a.Level = Access.AccessLevel.Receptionist;
                            break;
                        case "Manager":
                            a.Level = Access.AccessLevel.Manager;
                            break;
                        case "Administrator":
                            a.Level = Access.AccessLevel.Administrator;
                        break;
                    }
                    Console.WriteLine(a.EmployeeID + " " + a.Password + " " + a.Level);
                    accesses.Add(a);
                }
            }
        
        public void changeAccessLevel(long eid, Access.AccessLevel al)
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (eid == Convert.ToInt64(r["employeeid"]))
                {
                    r["accesslevel"] = al;
                    break;
                }
            }
            UpdateDataSource(selectCommand, table);
            Fill(selectCommand, table);
            fillWithAccess();

        }

        public void changePassword(long eid, string password)
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (eid == Convert.ToInt64(r["employeeid"]))
                {
                    r["password_"] = password;
                    break;
                }
            }
             ;
            UpdateDataSource(selectCommand, table);
            Fill(selectCommand, table);
            fillWithAccess();
        }

        public void AddAccess(long eid, string password, Access.AccessLevel al)
        {
            Access access = new Access(eid, password, al);
            DataRow r = ds.Tables[table].NewRow();
            FillRow(r, access, table, Operation.Add);
            accesses.Add(access);
        }
        public Access.AccessLevel checkLoginDetails(long eid, string pword)
        {
            Access.AccessLevel a = Access.AccessLevel.None;
            foreach (Access ac in accesses)
            {
                
                if (ac.EmployeeID ==  eid && ac.Password == pword)
                {

                    switch ((ac.Level))
                    {
                        case Access.AccessLevel.Administrator:
                            a = Access.AccessLevel.Administrator;
                        break;
                        case Access.AccessLevel.Manager:
                            a = Access.AccessLevel.Manager;
                        break;
                        case Access.AccessLevel.Receptionist:
                            a = Access.AccessLevel.Receptionist;
                        break;
                    }
                    return a;
                }
            }
            return a;
        }

    }
}
