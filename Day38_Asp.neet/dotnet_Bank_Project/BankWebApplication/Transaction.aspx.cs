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
    public partial class Transaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            Trans trans = new Trans();
            trans.AccountNo = Convert.ToInt32(txtAccountNo.Text);
            trans.TranAmount = Convert.ToInt32(txtTranAmount.Text);
            BankDAO dao = new BankDAO();
            Response.Write(dao.DepositAccount(trans));
        }

        protected void btnWithdraw_Click(object sender, EventArgs e)
        {
            Trans trans = new Trans();
            trans.AccountNo = Convert.ToInt32(txtAccountNo.Text);
            trans.TranAmount = Convert.ToInt32(txtTranAmount.Text);
            BankDAO dao = new BankDAO();
            Response.Write(dao.WithdrawAccount(trans));
        }
    }
}