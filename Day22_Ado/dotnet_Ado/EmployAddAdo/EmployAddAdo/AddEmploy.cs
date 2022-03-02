using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EmployAddAdo
{
    internal class AddEmploy
    {
        static void Main(string[] args)
        {
            int empno, basic;
            string name, dept, desig;
            Console.WriteLine("Enter Employ No    ");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name   ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department   ");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Designation   ");
            desig = Console.ReadLine();
            Console.WriteLine("Enter Basic    ");
            basic = Convert.ToInt32(Console.ReadLine());
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");
            DataRow dr = ds.Tables["EmpDummy"].NewRow();
            dr["empno"] = empno;
            dr["nam"] = name;
            dr["dept"] = dept;
            dr["desig"] = desig;
            dr["basic"] = basic;
            ds.Tables["EmpDummy"].Rows.Add(dr);
            ad.Update(ds, "EmpDummy");
            // reflect all changes of dataset (ds) to Emp table
            Console.WriteLine("Record Inserted...");
        }
    }
}
