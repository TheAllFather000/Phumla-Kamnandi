using Microsoft.VisualBasic;
using Phumla.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Data
{
    public class GuestCreationDB : DB
    {
        public const string particularyear = "SELECT employeeid AS EmployeeID, COUNT(*) AS Total_Guest FROM GuestCreationLog WHERE YEAR(GuestCreationLog.date) = {0} Group by employeeid";
        public const string before = "SELECT employeeid AS EmployeeID, COUNT(*) AS Total_Guest FROM GuestCreationLog WHERE GuestCreationLog.date <'{0}' Group by employeeid";
        public const string after = "SELECT employeeid AS EmployeeID , COUNT(*) AS Total_Guest FROM GuestCreationLog WHERE GuestCreationLog.date >'{0}' Group by employeeid";
        public const string between = "SELECT employeeid AS EmployeeID, COUNT(*) AS Total_Guest FROM GuestCreationLog WHERE GuestCreationLog.date >'{0}' AND GuestCreationLog.date < '{1}' Group by employeeid";
        public GuestCreationDB()
        {
            Fill("Select * From GuestCreationLog", "GuestCreationLog");
        }

        public void selectData(string selectCommand)
        {
            Fill(selectCommand, "GuestCreationLog");
        }
        public DataSet getDataSet()
        {
            return ds;
        }
        public bool newEntry(string id, string eid)
        {
            GCLog g = new GCLog(id, eid);
            DataRow r = ds.Tables["GuestCreationLog"].NewRow();
            return FillRow(r, g, "GuestCreationLog", Operation.Add);
        }

        public void getYearData(string year)
        {
            string select = string.Format(particularyear, year);
            Console.WriteLine(select);

            selectData(select);
        }
        public void getBefore(string period)
        {
            string select = string.Format(before, period);
            Console.WriteLine(select);
            selectData(select);
        }
        public void getAfter(string period)
        {
            string select = string.Format(after, period);
            Console.WriteLine(select);

            selectData(select);
        }
        public void getBetween(string period, string period2)
        {
            string select = string.Format(between, period, period2);
            Console.WriteLine(select);

            selectData(select);
        }
        
    }
}
