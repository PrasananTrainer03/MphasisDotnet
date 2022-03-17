using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcRealTime
{
    internal class EmploySearchMain
    {
        static void Main()
        {
            int empno;
            Console.WriteLine("Enter Employ No    ");
            empno = Convert.ToInt32(Console.ReadLine());
            EmployDAO dao = new EmployDAO();
            Employ employ = dao.SearchEmploy(empno);
            if (employ!=null)
            {
                Console.WriteLine(employ);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
    }
}
