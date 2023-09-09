using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DAL
{
    public class DbContext
    {
        SqlConnection conn;

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public DbContext()
        {
            conn = new SqlConnection("server=DESKTOP-7S9OK2B\\MSS;database=ITi;trusted_connection=true;TrustServerCertificate=True;");
        }


        // Disconnected mode with select
        public DataTable GetData(string command)
        {

            adapter.SelectCommand = new SqlCommand(command, conn);
            adapter.Fill(dataTable);
            return dataTable;
        }



        // connected mode with insert, update, delete
        public int ExecuteNonQuery(string command, SqlParameter[] parameters)
        {
            SqlCommand sqlCommand = new SqlCommand(command, conn);
            sqlCommand.Parameters.AddRange(parameters);
            conn.Open();
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            conn.Close();
            return rowsAffected;

        }
      


    }
}
