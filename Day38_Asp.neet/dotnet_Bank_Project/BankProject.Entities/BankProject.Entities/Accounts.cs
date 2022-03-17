using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Entities
{
    public class Accounts
    {
        public int AccountNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get;set; }
        public int Amount { get; set; }
        public string CheqFacil { get; set; }
        public string AccountType { get; set; }

        public override string ToString()
        {
            return "Account No  " + AccountNo + " First Name  " + FirstName + " Last Name " + LastName +
                "City  " + City + " State " + State + " Amount " + Amount + " CheqFacil  " + CheqFacil 
                + " Account Type " +AccountType;
        }
    }
}
