using System;
using System.Collections.Generic;
using System.Linq;
using BankProject.Entities;
using BankProject.DAO;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Main
{
    internal class CloseAccountMain
    {
        static void Main()
        {
            int accountNo;
            Console.WriteLine("Enter AccountNo   ");
            accountNo = Convert.ToInt32(Console.ReadLine());
            BankDAO dao = new BankDAO();
            Console.WriteLine(dao.CloseAccount(accountNo));
        }
    }
}
