using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class DbConnection
    {
        public SqlConnection connection = new SqlConnection(@ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);

    }
}
