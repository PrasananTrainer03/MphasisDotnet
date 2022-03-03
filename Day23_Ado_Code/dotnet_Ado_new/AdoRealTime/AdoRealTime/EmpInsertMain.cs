using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoRealTime
{
    internal class EmpInsertMain
    {
        static void Main()
        {
            Emp emp = new Emp();
            Console.WriteLine("Enter Employ No...");
            emp.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name  ");
            emp.Nam = Console.ReadLine();
            Console.WriteLine("Enter Department  ");
            emp.Dept = Console.ReadLine();
            Console.WriteLine("Enter Designation  ");
            emp.Desig = Console.ReadLine();
            Console.WriteLine("Enter Basic  ");
            emp.Basic = Convert.ToInt32(Console.ReadLine());
            EmpDAO dao = new EmpDAO();
            Console.WriteLine(dao.AddEmploy(emp));
        }
    }
}
