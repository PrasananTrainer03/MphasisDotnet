using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AdoRealTime
{
    //public class BankConnectionHelper
    //{
    //    public static SqlConnection GetConnection()
    //    {
    //        string strcon = ConfigurationManager.ConnectionStrings["bankdbconnection"].ConnectionString;
    //        SqlConnection conn = new SqlConnection(strcon);
    //        return conn;
    //    }
    //}
    public class ConnectionHelper
    {
        public static SqlConnection GetConnection()
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
}
