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
    internal class EmployInsertMain
    {
       static void Main()
        {
            string name, gender, dept, desig;
            int basic;
            Console.WriteLine("Enter Employ Name    ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender   ");
            gender = Console.ReadLine();
            Console.WriteLine("Enter Department   ");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Designation   ");
            desig = Console.ReadLine();
            Console.WriteLine("Enter Basic   ");
            basic = Convert.ToInt32(Console.ReadLine());
            string strcon = ConfigurationManager.ConnectionStrings["practicespconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcEmployInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@empno", SqlDbType.Int));
            cmd.Parameters["@empno"].Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dept", dept);
            cmd.Parameters.AddWithValue("@desig", desig);
            cmd.Parameters.AddWithValue("@basic", basic);
            cmd.ExecuteNonQuery();
            int empno = Convert.ToInt32(cmd.Parameters["@empno"].Value);
            Console.WriteLine("Mr/Ms " + name + " Your Employ No is " +empno);
            
        }
    }
}
