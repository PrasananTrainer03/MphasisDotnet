using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoRealTime
{
    internal class EmployDeleteMain
    {
        static void Main()
        {
            int empno;
            Console.WriteLine("Enter Employ Number   ");
            empno = Convert.ToInt32(Console.ReadLine());
            EmpDAO dao = new EmpDAO();
            Console.WriteLine(dao.DeleteEmploy(empno));
        }
    }
}
