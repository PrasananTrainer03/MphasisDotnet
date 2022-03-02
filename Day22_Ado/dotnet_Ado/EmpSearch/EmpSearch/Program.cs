using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace EmpSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno;
            Console.WriteLine("Enter Employ No     ");
            empno = Convert.ToInt32(Console.ReadLine());
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp where empno=@empno", conn);
            ad.SelectCommand.Parameters.AddWithValue("@empno", empno);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");
            int count = ds.Tables["EmpDummy"].Rows.Count;
            if (count==1)
            {
                DataRow dr = ds.Tables["EmpDummy"].Rows[0];
                Console.WriteLine("Employ Name  " +ds.Tables["EmpDummy"].Rows[0]["Nam"]);
                Console.WriteLine("Employ Name    " + dr["nam"]);
                Console.WriteLine("Department   " + dr["dept"]);
                Console.WriteLine("Desigantion   " + dr["desig"]);
                Console.WriteLine("Basic   " + dr["basic"]);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
    }
}
