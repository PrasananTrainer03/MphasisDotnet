using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoRealTime
{
    internal class EmpSearchMain
    {
        static void Main()
        {
            int empno;
            Console.WriteLine("Enter Employ Number   ");
            empno = Convert.ToInt32(Console.ReadLine());
            EmpDAO dao = new EmpDAO();
            Emp emp = dao.SearchEmp(empno);
            if (emp!=null)
            {
                Console.WriteLine(emp);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }

        }
    }
}
