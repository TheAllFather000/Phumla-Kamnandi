using Phumla.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Phumla.Data
{
//generic DB class
    public class DB
    {
               protected string s = Settings.Default.PKDatabaseConnectionString;
               private SqlConnection connection;
               private SqlCommand command;
               private DataSet ds;
               private SqlDataAdapter adapter;

        public DB()
        {
            try
            {
                connection = new SqlConnection(s);
                ds = new DataSet();

            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message+ " Error","Error");
                return;
            }
        }
        #region filltable
        public void Fill(string query, string table)
        {
            try
            {
                adapter = new SqlDataAdapter(query, connection);
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
    }
}
