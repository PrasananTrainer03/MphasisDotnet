using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace StoredProcRealTime
{
    public class ConnectionHelper
    {
        public static SqlConnection GetConnection()
        {
            string strcon = ConfigurationManager.ConnectionStrings["practicespconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
}
