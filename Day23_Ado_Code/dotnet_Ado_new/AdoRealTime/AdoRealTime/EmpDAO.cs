using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AdoRealTime
{
    public class EmpDAO
    {
        SqlConnection connection;
        SqlDataAdapter adapter;

        public string UpdateEmploy(Emp emp)
        {
            Emp empFound = SearchEmp(emp.Empno);
            if (empFound!=null)
            {
                connection = ConnectionHelper.GetConnection();
                adapter = new SqlDataAdapter("select * from Emp where empno=@empno", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@empno", emp.Empno);
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "EmpDummy");
                DataRow dr = ds.Tables["EmpDummy"].Rows[0];
                dr["nam"] = emp.Nam;
                dr["dept"] = emp.Dept;
                dr["desig"] = emp.Desig;
                dr["basic"] = emp.Basic;
                adapter.Update(ds, "EmpDummy");
                return "Record Updated...";

            }
            return "Employ Record Not Found...";
        }
        public string DeleteEmploy(int empno)
        {
            Emp emp = SearchEmp(empno);
            if (emp!=null)
            {
                connection = ConnectionHelper.GetConnection();
                adapter = new SqlDataAdapter("select * from Emp where empno=@empno", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@empno", empno);
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "EmpDummy");
                DataRow dr = ds.Tables["EmpDummy"].Rows[0];
                dr.Delete();
                adapter.Update(ds, "EmpDummy");
                return "Employ Record Deleted...";
            }
            return "Employ Record Not Found...";
        }
        public string AddEmploy(Emp emp)
        {
            connection = ConnectionHelper.GetConnection();
            adapter = new SqlDataAdapter("select * from Emp", connection);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "EmpDummy");
            DataRow dr = ds.Tables["EmpDummy"].NewRow();
            dr["empno"] = emp.Empno;
            dr["nam"] = emp.Nam;
            dr["dept"] = emp.Dept;
            dr["desig"] = emp.Desig;
            dr["basic"] = emp.Basic;
            ds.Tables["EmpDummy"].Rows.Add(dr);
            adapter.Update(ds, "EmpDummy");
            return "Record Inserted...";
        }
        public Emp SearchEmp(int empno)
        {
            connection = ConnectionHelper.GetConnection();
            adapter = new SqlDataAdapter("select * from Emp where empno=@empno", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@empno", empno);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "EmpDummy");
            Emp emp = null;
            int count = ds.Tables["EmpDummy"].Rows.Count;
            if (count==1)
            {
                emp = new Emp();
                DataRow dr = ds.Tables["EmpDummy"].Rows[0];
                emp.Empno = Convert.ToInt32(dr["empno"]);
                emp.Nam = dr["nam"].ToString();
                emp.Dept = dr["dept"].ToString();
                emp.Desig = dr["desig"].ToString();
                emp.Basic = Convert.ToInt32(dr["basic"]);
            }
            return emp;
        }

        public List<Emp> ShowEmploy()
        {
            connection = ConnectionHelper.GetConnection();
            adapter = new SqlDataAdapter("select * from Emp", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "EmpDummy");
            List<Emp> employList = new List<Emp>();
            Emp emp = null;
            foreach(DataRow dr in ds.Tables["EmpDummy"].Rows)
            {
                emp = new Emp();
                emp.Empno = Convert.ToInt32(dr["empno"]);
                emp.Nam = dr["nam"].ToString();
                emp.Dept = dr["dept"].ToString();
                emp.Desig = dr["desig"].ToString();
                emp.Basic = Convert.ToInt32(dr["basic"]);
                employList.Add(emp);
            }
            return employList;
        }
    }
}
