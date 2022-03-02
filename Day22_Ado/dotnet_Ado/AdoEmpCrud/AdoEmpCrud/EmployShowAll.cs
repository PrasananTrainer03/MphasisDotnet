using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AdoEmpCrud
{
    internal class EmployShowAll
    {
        static void Main(string[] args)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection connection = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * From Emp", connection);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");
            //SqlDataAdapter ad1 = new SqlDataAdapter("select * from Agent", connection);
            //ad.Fill(ds, "AgentDummy");
            foreach(DataRow dr in ds.Tables["EmpDummy"].Rows)
            {
                Console.WriteLine("Employ No   " +dr["empno"]);
                Console.WriteLine("Employ Name  " +dr["nam"]);
                Console.WriteLine("Department   " +dr["dept"]);
                Console.WriteLine("Designation   " +dr["desig"]);
                Console.WriteLine("Basic   " +dr["basic"]);
                Console.WriteLine("-------------------------------------------------");
            }
        }

    }
}
