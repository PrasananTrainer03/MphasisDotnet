using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace ConnectedDemo
{
    internal class EmployDeleteMain
    {
        static void Main()
        {
            string strcon = ConfigurationManager.ConnectionStrings["practicespconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            int empno;
            Console.WriteLine("Enter Employ Number    ");
            empno = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("prcEmployDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empno", empno);
            cmd.ExecuteNonQuery();
            Console.WriteLine("*** Record Deleted ***");
        }
    }
}
