using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApp1
{
    public partial class EmployTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp", conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");
            grdEmp.DataSource = ds.Tables["EmpDummy"];
            grdEmp.DataBind();
        }
    }
}