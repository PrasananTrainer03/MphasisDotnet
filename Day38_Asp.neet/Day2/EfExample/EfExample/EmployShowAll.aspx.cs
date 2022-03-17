using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EfExample
{
    public partial class EmployShowAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlpracticeEntities1 entities = new sqlpracticeEntities1();
            var result = entities.EMps.Select(x => x);
            grdEmployShow.DataSource = result.ToList();
            grdEmployShow.DataBind();
        }
    }
}