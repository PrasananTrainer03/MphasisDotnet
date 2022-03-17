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
    internal class Program
    {
        static void Main(string[] args)
        {
            string strcon = ConfigurationManager.ConnectionStrings["practicespconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcEmployShow", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("Employ No   " +dr["Empno"]);
                Console.WriteLine("Employ Name   " +dr["name"]);
                Console.WriteLine("Department   " +dr["dept"]);
                Console.WriteLine("Gender  " +dr["gender"]);
                Console.WriteLine("Designation   " +dr["desig"]);
                Console.WriteLine("Basic    " +dr["basic"]);
                Console.WriteLine("-----------------------------------");
            }
            conn.Close();
        }
    }
}
