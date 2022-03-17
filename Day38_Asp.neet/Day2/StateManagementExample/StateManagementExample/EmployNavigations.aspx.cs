using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementExample
{
    public partial class EmployNavigations : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlDataAdapter ad;
        DataSet dataset;

        int i, count;

        public void ShowEmploy()
        {
            txtEmpno.Text = dataset.Tables["EmpDummy"].Rows[i]["empno"].ToString();
            txtName.Text = dataset.Tables["EmpDummy"].Rows[i]["nam"].ToString();
            txtDept.Text = dataset.Tables["EmpDummy"].Rows[i]["dept"].ToString();
            txtDesig.Text = dataset.Tables["EmpDummy"].Rows[i]["desig"].ToString();
            txtBasic.Text = dataset.Tables["EmpDummy"].Rows[i]["basic"].ToString();
        }

        protected void btnFirst_Click(object sender, EventArgs e)
        {
            i = 0;
            ViewState["i"] = i;
            ShowEmploy();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            i = (int)ViewState["i"];
            i++;
            ViewState["i"] = i;
            ShowEmploy();
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            i = (int)ViewState["i"];
            i--;
            ViewState["i"] = i;
            ShowEmploy();
        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            i = (int)ViewState["count"];
            i--;
            ViewState["count"] = i;
            ShowEmploy();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            conn = new SqlConnection(strcon);
            ad = new SqlDataAdapter("select * from Emp", conn);
            dataset = new DataSet();
            ad.Fill(dataset, "EmpDummy");
            if (!IsPostBack)
            {
                i = 0;
                count = dataset.Tables["EmpDummy"].Rows.Count;
                ViewState["i"] = i;
                ViewState["count"] = count;
            }
            ShowEmploy();
        }
    }
}