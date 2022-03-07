using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ConnectedDemo
{
    internal class EmploySearchOutExample
    {
        static void Main()
        {
            int empno;
            Console.WriteLine("Enter Employ No    ");
            empno = Convert.ToInt32(Console.ReadLine());
            string strcon = ConfigurationManager.ConnectionStrings["practicespconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcEmployOutExample", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empno", empno);
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 30));
            cmd.Parameters["@name"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add(new SqlParameter("@gender", SqlDbType.VarChar, 10));
            cmd.Parameters["@gender"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add(new SqlParameter("@dept", SqlDbType.VarChar, 30));
            cmd.Parameters["@dept"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add(new SqlParameter("@desig", SqlDbType.VarChar, 30));
            cmd.Parameters["@desig"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add(new SqlParameter("@basic", SqlDbType.Int));
            cmd.Parameters["@basic"].Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            Console.WriteLine("Employ Name  " +cmd.Parameters["@name"].Value);
            Console.WriteLine("Gender   " +cmd.Parameters["@gender"].Value);
            Console.WriteLine("Department   " +cmd.Parameters["@dept"].Value);
            Console.WriteLine("Designataion  " +cmd.Parameters["@desig"].Value);
            Console.WriteLine("Basic   " +cmd.Parameters["@basic"].Value);
        }
    }
}
