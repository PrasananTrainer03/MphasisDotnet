using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace UserAuthentication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName, passCode;
            Console.WriteLine("Enter UserName   ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter Password   ");
            passCode = Console.ReadLine();
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select count(*) cnt from Users where username=@userName AND " +
                " Passcode=@passCode", conn);
            ad.SelectCommand.Parameters.AddWithValue("@userName", userName);
            ad.SelectCommand.Parameters.AddWithValue("@passCode", passCode);
            DataSet ds = new DataSet();
            ad.Fill(ds, "UsersDummy");
            int count = Convert.ToInt32(ds.Tables["UsersDummy"].Rows[0]["cnt"]);
            if (count==1)
            {
                Console.WriteLine("Correct Credentials...");
            }
            else
            {
                Console.WriteLine("Invalid Credentials...");
            }
        }
    }
}
