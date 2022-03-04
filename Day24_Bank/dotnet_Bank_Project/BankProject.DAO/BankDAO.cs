using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BankProject.Entities;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BankProject.DAO
{
    public class BankDAO
    {
        SqlConnection conn;
        SqlDataAdapter ad;

        public int GenerateAccountNo()
        {
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select case when max(accountNo) IS NULL THEN 1 ELSE MAX(AccountNo) + 1 " +
                " END accno from Accounts", conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "AccountsDummy");
            int accno = Convert.ToInt32(ds.Tables["AccountsDummy"].Rows[0]["accno"]);
            return accno;
        }

        public string CloseAccount(int accountNo)
        {
            Accounts accountFound = SearchAccount(accountNo);
            if (accountFound!=null)
            {
                conn = ConnectionHelper.GetConnection();
                ad = new SqlDataAdapter("select * from Accounts Where AccountNo=@accountNo", conn);
                ad.SelectCommand.Parameters.AddWithValue("@accountNo", accountNo);
                SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
                DataSet ds = new DataSet();
                ad.Fill(ds, "AccountsDummy");
                DataRow dr = ds.Tables["AccountsDummy"].Rows[0];
                dr["status"] = "inactive";
                ad.Update(ds, "AccountsDummy");
                return "Account Closed...";
            }
            return "Account No not Found...";
        }
        public Accounts SearchAccount(int accountNo)
        {
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from Accounts Where AccountNo=@accountNo", conn);
            ad.SelectCommand.Parameters.AddWithValue("@accountNo", accountNo);
            DataSet ds = new DataSet();
            ad.Fill(ds, "AccountsDummy");
            int count = ds.Tables["AccountsDummy"].Rows.Count;
            Accounts accounts = null;
            if (count==1)
            {
                accounts = new Accounts();
                DataRow dr = ds.Tables["AccountsDummy"].Rows[0];
                accounts.AccountNo = accountNo;
                accounts.FirstName = dr["FirstName"].ToString();
                accounts.LastName = dr["LastName"].ToString();
                accounts.City = dr["City"].ToString();
                accounts.State = dr["state"].ToString();
                accounts.Amount = Convert.ToInt32(dr["Amount"]);
                accounts.CheqFacil = dr["CheqFacil"].ToString();
                accounts.AccountType = dr["AccountType"].ToString();
            }
            return accounts;
        }
        public string CreateAccount(Accounts accounts)
        {
            int accno = GenerateAccountNo();
            accounts.AccountNo = accno;
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from Accounts", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds, "AccountsDummy");
            DataRow dr = ds.Tables["AccountsDummy"].NewRow();
            dr["AccountNo"] = accounts.AccountNo;
            dr["FirstName"] = accounts.FirstName;
            dr["LastName"] = accounts.LastName;
            dr["city"] = accounts.City;
            dr["state"] = accounts.State;
            dr["amount"] = accounts.Amount;
            dr["CheqFacil"] = accounts.CheqFacil;
            dr["AccountType"] = accounts.AccountType;
            ds.Tables["AccountsDummy"].Rows.Add(dr);
            ad.Update(ds, "AccountsDummy");
            return "Account Created...";
        }

        public string WithdrawAccount(Trans trans)
        {
            Accounts accounts = SearchAccount(trans.AccountNo);
            if (accounts != null)
            {
                int amount = accounts.Amount;
                int diff = amount - trans.TranAmount;
                if (diff >= 1000)
                {
                   // accounts.Amount += trans.TranAmount;
                    ad = new SqlDataAdapter("select * from Accounts where AccountNo=@accountNo", conn);
                    ad.SelectCommand.Parameters.AddWithValue("@accountNo", trans.AccountNo);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
                    DataSet ds = new DataSet();
                    ad.Fill(ds, "AccountsDummy");
                    DataRow dr = ds.Tables["AccountsDummy"].Rows[0];
                    dr["Amount"] = diff;
                    ad.Update(ds, "AccountsDummy");
                    ad.Dispose();
                    ds.Clear();
                    ad = new SqlDataAdapter("select * from trans", conn);
                    cmd = new SqlCommandBuilder(ad);
                    ds = new DataSet();
                    ad.Fill(ds, "TransDummy");
                    dr = ds.Tables["TransDummy"].NewRow();
                    dr["AccountNo"] = trans.AccountNo;
                    dr["TranAmount"] = trans.TranAmount;
                    dr["TranType"] = "D";
                    ds.Tables["TransDummy"].Rows.Add(dr);
                    ad.Update(ds, "TransDummy");
                    return "Amount Debited...";
                }
                else
                {
                    return "Insufficient Funds...";
                }
            }
            return "Account No Not Found...";
        }
        public string DepositAccount(Trans trans)
        {
            Accounts accounts = SearchAccount(trans.AccountNo);
            if (accounts!=null)
            {
                accounts.Amount += trans.TranAmount;
                ad = new SqlDataAdapter("select * from Accounts where AccountNo=@accountNo", conn);
                ad.SelectCommand.Parameters.AddWithValue("@accountNo", trans.AccountNo);
                SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
                DataSet ds = new DataSet();
                ad.Fill(ds, "AccountsDummy");
                DataRow dr = ds.Tables["AccountsDummy"].Rows[0];
                dr["Amount"] = accounts.Amount;
                ad.Update(ds, "AccountsDummy");
                ad.Dispose();
                ds.Clear();
                ad = new SqlDataAdapter("select * from trans", conn);
                cmd = new SqlCommandBuilder(ad);
                ds = new DataSet();
                ad.Fill(ds, "TransDummy");
                dr = ds.Tables["TransDummy"].NewRow();
                dr["AccountNo"] = trans.AccountNo;
                dr["TranAmount"] = trans.TranAmount;
                dr["TranType"] = "C";
                ds.Tables["TransDummy"].Rows.Add(dr);
                ad.Update(ds, "TransDummy");
                return "Amount Credited...";
            }
            return "Account No Not Found...";
        }
    }
}
