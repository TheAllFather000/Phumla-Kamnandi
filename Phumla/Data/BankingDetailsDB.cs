using Microsoft.VisualBasic;
using Phumla.Business;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Phumla.Data
{
    public class BankingDetailsDB:DB
    {
        private string table = "BankingDetails";
        private Collection<BankingDetails> details;
        public Collection<BankingDetails> Details
        { get { return details; } 
        set { details = value; }}
        public BankingDetailsDB():base()
        {
            details = new Collection<BankingDetails>();
            Fill("Select * From BankingDetails", table);
            FillWithDetails();
        }

        public void FillWithDetails()
        {
            details.Clear();
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                BankingDetails bd = new BankingDetails();
                bd.IDNumber = Convert.ToInt64(r["id"]);
                bd.CVV = Convert.ToInt32(r["cvv"]);
                bd.ExpiryDate = Convert.ToString(r["expiryDate"]);
                bd.CardNumber = Convert.ToInt64(r["cardNumber"]);
                details.Add(bd);
            }
        }
        public BankingDetails getBankingDetails(long id)
        {
            foreach (BankingDetails bd in  details)
            {
                if (bd.IDNumber == id)
                { return bd; }
            }
            return null;
        }
        public bool DeleteEntry(long id)
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["id"]) == (id))
                {
                    r.Delete();
                }

            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            bool success =UpdateDataSource("SELECT * From BankingDetails", table);
            FillWithDetails();
            return success;
        }
        public bool AddNewBankingDetails(BankingDetails bd)
        {
            DataRow r = ds.Tables[table].NewRow();
            bool success = FillRow(r, bd, table, DB.Operation.Add);
            ds.Tables[table].Rows.Add(r);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            FillWithDetails();
            return success;
        }
        public bool editBankingDetails(BankingDetails bd)
        {
            bool success = false;
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (Convert.ToInt64(r["guestid"]) == bd.IDNumber)
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    success = FillRow(r, bd, table, Operation.Edit);
                    break;
                }
            }
            FillWithDetails() ;
            return success;
        }
    }
}
