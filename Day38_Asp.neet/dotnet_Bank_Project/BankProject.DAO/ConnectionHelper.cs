using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.DAO
{
    public class ConnectionHelper
    {
        public static SqlConnection GetConnection()
        {
            string strcon = ConfigurationManager.ConnectionStrings["bankconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
}
