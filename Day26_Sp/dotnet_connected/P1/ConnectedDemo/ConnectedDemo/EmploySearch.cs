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
    internal class EmploySearch
    {
        static void Main()
        {
            int empno;
            Console.WriteLine("Enter Employ No    ");
            empno = Convert.ToInt32(Console.ReadLine());
            string strcon = ConfigurationManager.ConnectionStrings["practicespconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcEmploySearch", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empno", empno);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Console.WriteLine("Employ No   " + dr["Empno"]);
                Console.WriteLine("Employ Name   " + dr["name"]);
                Console.WriteLine("Department   " + dr["dept"]);
                Console.WriteLine("Gender  " + dr["gender"]);
                Console.WriteLine("Designation   " + dr["desig"]);
                Console.WriteLine("Basic    " + dr["basic"]);
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
    }
}
