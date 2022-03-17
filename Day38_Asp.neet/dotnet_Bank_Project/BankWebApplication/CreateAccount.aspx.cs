using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using BankProject.Entities;
using BankProject.DAO;
using System.Web.UI.WebControls;

namespace BankWebApplication
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlAccountType.Items.Add("Savings");
                ddlAccountType.Items.Add("Current");
                ddlCheqFacility.Items.Add("Yes");
                ddlCheqFacility.Items.Add("No");
            }
        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts();
            accounts.FirstName = txtFirstName.Text;
            accounts.LastName = txtLastName.Text;
            accounts.City = txtCity.Text;
            accounts.State = txtState.Text;
            accounts.Amount = Convert.ToInt32(txtAmount.Text);
            accounts.CheqFacil = ddlCheqFacility.Text;
            accounts.AccountType = ddlAccountType.Text;
            BankDAO dao = new BankDAO();
            Response.Write(dao.CreateAccount(accounts));
        }
    }
}