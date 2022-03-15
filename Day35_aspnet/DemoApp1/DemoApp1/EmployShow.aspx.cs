using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApp1
{
    public partial class EmployShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp", conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");
            int i = 0;
            txtEmpno.Text=ds.Tables["EmpDummy"].Rows[i]["empno"].ToString();
            txtName.Text = ds.Tables["EmpDummy"].Rows[i]["nam"].ToString();
            txtDept.Text = ds.Tables["EmpDummy"].Rows[i]["dept"].ToString();
            txtDesig.Text = ds.Tables["EmpDummy"].Rows[i]["desig"].ToString();
            txtBasic.Text = ds.Tables["EmpDummy"].Rows[i]["basic"].ToString();
        }
    }
}