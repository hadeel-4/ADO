using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataDAL
    {
        DataTable table = new DataTable();
        public DataTable ReadData()
        {
            DbConnection dbConnection = new DbConnection();
            if (ConnectionState.Closed == dbConnection.connection.State)
            {
                dbConnection.connection.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Question", dbConnection.connection);
            try
            {
                SqlDataReader dataReader = cmd.ExecuteReader();
                table.Load(dataReader);
                return table;

            }
            catch
            {
                throw;
            }

         }

    }
}
