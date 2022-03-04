using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankProject.DAO;
using BankProject.Entities;
using System.Threading.Tasks;

namespace BankProject.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accounts accounts = new Accounts();
            Console.WriteLine("Enter FirstName   ");
            accounts.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName   ");
            accounts.LastName = Console.ReadLine();
            Console.WriteLine("Enter City   ");
            accounts.City = Console.ReadLine();
            Console.WriteLine("Enter State  ");
            accounts.State = Console.ReadLine();
            Console.WriteLine("Enter Amount  ");
            accounts.Amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter CheqFacility  ");
            accounts.CheqFacil = Console.ReadLine();
            Console.WriteLine("Enter AccountType   ");
            accounts.AccountType = Console.ReadLine();

            BankDAO dao = new BankDAO();
            Console.WriteLine(dao.CreateAccount(accounts));
        }
    }
}
