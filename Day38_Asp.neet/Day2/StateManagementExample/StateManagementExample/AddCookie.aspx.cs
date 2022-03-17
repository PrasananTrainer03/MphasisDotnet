using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementExample
{
    public partial class AddCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddCookie_Click(object sender, EventArgs e)
        {
            HttpCookie ckArka = new HttpCookie("Arka", "99");
            ckArka.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(ckArka);

            HttpCookie ckSakshi = new HttpCookie("Sakshi", "78");
            ckSakshi.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(ckSakshi);

            HttpCookie ckSrikanth = new HttpCookie("Srikanth", "89");
            ckSrikanth.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(ckSrikanth);

            Response.Write("Cookies are Created...");
        }

        protected void btnReadCookie_Click(object sender, EventArgs e)
        {
            HttpCookie ckArka, ckSakshi, ckSrikanth;
            ckArka = Request.Cookies.Get("Arka");
            Response.Write("Arka Score is  " + ckArka.Value + "<br/>") ;
            ckSrikanth = Request.Cookies.Get("Srikanth");
            Response.Write("Srikanth's Score is  " + ckSrikanth.Value + "<br/>");
            ckSakshi = Request.Cookies.Get("Sakshi");
            Response.Write("Sakshi's Score is  " + ckSakshi.Value + "<br/>");
                
        }
    }
}