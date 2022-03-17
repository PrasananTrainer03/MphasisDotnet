using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankProject.DAO;
using BankProject.Entities;
using System.Threading.Tasks;

namespace BankProject.Main
{
    internal class SearchAccountMain
    {
        static void Main()
        {
            int accountNo;
            Console.WriteLine("Enter AccountNo   ");
            accountNo = Convert.ToInt32(Console.ReadLine());
            BankDAO dao = new BankDAO();
            Accounts accounts = dao.SearchAccount(accountNo);
            if (accounts!=null)
            {
                Console.WriteLine(accounts);
            }
            else {
                Console.WriteLine("Account No Not Found...");
            }
               
        }
    }
}
