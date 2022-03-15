using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApp1
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlNames.Items.Add("Momita");
                ddlNames.Items.Add("Arka Mitra");
                ddlNames.Items.Add("Srikanth");
                ddlNames.Items.Add("Joash");
            }
        }

        protected void ddlNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Selected Name is   " + ddlNames.Text);
        }
    }
}