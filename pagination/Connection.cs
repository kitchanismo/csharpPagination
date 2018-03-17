using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace pagination
{
    class Connection
    {
        protected SqlConnection con = new SqlConnection();
        protected SqlCommand cmd = new SqlCommand();
        protected SqlDataReader dr;

        private string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\testdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        protected string query;

        public void Connected()
        {
            con.Close();
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = connString;
                con.Open();
            }
        }
    }
}
