using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpSpExample
{
    public partial class EmpShowSp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcEmpShow", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txtEmpno.Text = dr["empno"].ToString();
            txtName.Text = dr["nam"].ToString();
            txtDept.Text = dr["dept"].ToString();
            txtDesig.Text = dr["desig"].ToString();
            txtBasic.Text = dr["basic"].ToString();
        }
    }
}