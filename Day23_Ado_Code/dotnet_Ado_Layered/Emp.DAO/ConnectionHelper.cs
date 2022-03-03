using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Emp.DAO
{
    public class ConnectionHelper
    {
        public static SqlConnection GetConnection()
        {
            string strcon = "integrated security=true;data source=DESKTOP-1P9MIR5;initial catalog=sqlpractice";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
}
