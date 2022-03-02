using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AdoEmpDelete
{
    internal class EmployDelete
    {
        static void Main(string[] args)
        {
            int empno;
            Console.WriteLine("Enter Employ No    ");
            empno = Convert.ToInt32(Console.ReadLine());
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp where empno=@empno", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            ad.SelectCommand.Parameters.AddWithValue("@empno", empno);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");
            int count = ds.Tables["EmpDummy"].Rows.Count;
            if (count==1)
            {
                DataRow dr = ds.Tables["EmpDummy"].Rows[0];
                dr.Delete();
                ad.Update(ds, "EmpDummy");
                Console.WriteLine("Record Deleted...");
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
    }
}
