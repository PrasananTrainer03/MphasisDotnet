using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EfExample
{
    public partial class EmployDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchEmploy_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities1 entities = new sqlpracticeEntities1();
            int empno = Convert.ToInt32(txtEmpno.Text);
            EMp eMp = entities.EMps.Where(x => x.Empno == empno).FirstOrDefault<EMp>();
            if (eMp!=null)
            {
                txtName.Text = eMp.nam;
                txtDept.Text = eMp.dept;
                txtDesig.Text = eMp.desig;
                txtBasic.Text = eMp.basic.ToString();
            }
            else
            {
                Response.Write("*** Record Not Found ***");
            }
        }

        protected void btnAddEmploy_Click(object sender, EventArgs e)
        {
            EMp emp = new EMp();
            emp.Empno = Convert.ToInt32(txtEmpno.Text);
            emp.nam = txtName.Text;
            emp.dept = txtDept.Text;
            emp.desig = txtDesig.Text;
            emp.basic = Convert.ToInt32(txtBasic.Text);
            sqlpracticeEntities1 entities = new sqlpracticeEntities1();
            entities.EMps.Add(emp);
            entities.SaveChanges();
            Response.Write("*** Record Inserted ***");
        }
    }
}