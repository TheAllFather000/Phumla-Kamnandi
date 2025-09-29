using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using Phumla.Business;
using System.Collections.ObjectModel;
namespace Phumla.Data
{
    public class AccessDB : DB
    {
        public const string table = "Access";
        public const string selectCommand = "SELECT * FROM Access";
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
            accesses = new Collection<Access>();
            Access a = new Business.Access();
            foreach (DataRow row in ds.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {

                    a.EmployeeID = Convert.ToInt64(row["employeeid"]);
                    a.Password = Convert.ToString(row["password"]);
                    switch (Convert.ToString(row["accesslevel"]))
                    {
                        case "Receptionist":
                            a.Level = Access.AccessLevel.Receptionist;
                            break;
                        case "Manager":
                            a.Level = Access.AccessLevel.Manager;
                            break;
                    }
                    accesses.Add(a);
                }
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
            ds.AcceptChanges();
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
                    r["password"] = password;
                    break;
                }
            }
            ds.AcceptChanges();
            UpdateDataSource(selectCommand, table);
            Fill(selectCommand, table);
            fillWithAccess();
        }

        public Access.AccessLevel checkLoginDetails(long eid, string pword)
        {
            Access.AccessLevel a = Access.AccessLevel.Receptionist;
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["employeeid"]) == eid && Convert.ToString(r["password"]) == pword)
                {
                    switch (Convert.ToString(r["accesslevel"]))
                    {
                        case "Administrator":
                            a = Access.AccessLevel.Administrator;
                        break;
                        case "Manager":
                            a = Access.AccessLevel.Manager;
                        break;
                        case "Receptionist":
                            a = Access.AccessLevel.Receptionist;
                        break;
                    }
                }
                else
                {
                    return Access.AccessLevel.None;
                }
            }
            return a;
        }

    }
}
