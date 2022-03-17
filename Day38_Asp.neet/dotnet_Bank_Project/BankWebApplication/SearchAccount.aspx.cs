using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using BankProject.DAO;
using BankProject.Entities;
using System.Web.UI.WebControls;

namespace BankWebApplication
{
    public partial class SearchAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BankDAO dao = new BankDAO();
            int accountNo = Convert.ToInt32(txtAccountNo.Text);
            Accounts accounts = dao.SearchAccount(accountNo);
            txtFirstName.Text = accounts.FirstName;
            txtLastName.Text = accounts.LastName;
            txtCity.Text = accounts.City;
            txtState.Text = accounts.State;
        }
    }
}