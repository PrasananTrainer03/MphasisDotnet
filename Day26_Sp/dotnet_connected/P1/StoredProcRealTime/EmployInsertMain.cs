using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcRealTime
{
    internal class EmployInsertMain
    {
        static void Main()
        {
            Employ employ = new Employ();
            Console.WriteLine("Enter Employ Name    ");
            employ.Name = Console.ReadLine();
            Console.WriteLine("Enter Gender   ");
            employ.Gender = Console.ReadLine();
            Console.WriteLine("Enter Department   ");
            employ.Dept = Console.ReadLine();
            Console.WriteLine("Enter Designation   ");
            employ.Desig = Console.ReadLine();
            Console.WriteLine("Enter Basic   ");
            employ.Basic = Convert.ToInt32(Console.ReadLine());
            int empno = new EmployDAO().AddEmploy(employ);
            Console.WriteLine(empno);
        }
    }
}
