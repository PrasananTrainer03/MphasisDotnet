using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpSpExample
{
    public partial class EmployInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcEmpInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empno", Convert.ToInt32(txtEmpno.Text));
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@dept", txtDept.Text);
            cmd.Parameters.AddWithValue("@desig", txtDesig.Text);
            cmd.Parameters.AddWithValue("@basic", Convert.ToInt32(txtBasic.Text));
            cmd.ExecuteNonQuery();
            Response.Redirect("EmployTable.aspx");
        }
    }
}