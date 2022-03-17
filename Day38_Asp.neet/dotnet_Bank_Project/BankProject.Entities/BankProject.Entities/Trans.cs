using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Entities
{
    public class Trans
    {
            public int AccountNo { get; set; }
            public string TranType { get; set; }
            public int TranAmount { get; set; }
    }
}
