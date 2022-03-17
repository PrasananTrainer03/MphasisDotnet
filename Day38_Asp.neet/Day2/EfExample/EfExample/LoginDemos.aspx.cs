using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EfExample
{
    public partial class LoginDemos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Login1.UserName.Equals("Mphasis") && Login1.Password.Equals("Mphasis"))
            {
                Response.Redirect("EmployShowAll.aspx");
            }
            
        }
    }
}