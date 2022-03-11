using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDemo
{
    internal class EmpSearch
    {
        static void Main()
        {
            int empno;
            Console.WriteLine("Enter Employ Number   ");
            empno = Convert.ToInt32(Console.ReadLine());
            sqlpracticeEntities entities = new sqlpracticeEntities();
            EMp emp = entities.EMps.Where(x => x.Empno == empno).FirstOrDefault<EMp>();
            if (emp!=null)
            {
                Console.WriteLine("Employ No   " +emp.Empno);
                Console.WriteLine("Employ Name   " +emp.nam);
                Console.WriteLine("Department   " +emp.dept);
                Console.WriteLine("Designation   " +emp.desig);
                Console.WriteLine("Basic   " +emp.basic);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
    }
}
