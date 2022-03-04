using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankProject.Entities;
using BankProject.DAO;
using System.Threading.Tasks;

namespace BankProject.Main
{
    internal class DepositAccountMain
    {
        static void Main()
        {
            Trans trans = new Trans();
            Console.WriteLine("Enter AccountNo   ");
            trans.AccountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount    ");
            trans.TranAmount = Convert.ToInt32(Console.ReadLine());
            BankDAO dao = new BankDAO();
            Console.WriteLine(dao.DepositAccount(trans));           
        }
    }
}
