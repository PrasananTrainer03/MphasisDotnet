using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace DemoApp1
{
    public partial class EmployInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp where empno=@empno", conn);
            ad.SelectCommand.Parameters.AddWithValue("@empno", Convert.ToInt32(txtEmpno.Text));
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");
            int count = ds.Tables["EmpDummy"].Rows.Count;
            if (count==1)
            {
                txtName.Text = ds.Tables["EmpDummy"].Rows[0]["nam"].ToString();
                txtDept.Text = ds.Tables["EmpDummy"].Rows[0]["dept"].ToString();
                txtDesig.Text = ds.Tables["EmpDummy"].Rows[0]["desig"].ToString();
                txtBasic.Text = ds.Tables["EmpDummy"].Rows[0]["basic"].ToString();
            }
            else
            {
                Response.Write("Record Not Found...");
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");
            DataRow dr = ds.Tables["EmpDummy"].NewRow();
            dr["empno"] = Convert.ToInt32(txtEmpno.Text);
            dr["nam"] = txtName.Text;
            dr["dept"] = txtDept.Text;
            dr["desig"] = txtDesig.Text;
            dr["basic"] = Convert.ToInt32(txtBasic.Text);
            ds.Tables["EmpDummy"].Rows.Add(dr);
            ad.Update(ds, "EmpDummy");
            Response.Redirect("EmployTable.aspx");
        }
    }
}