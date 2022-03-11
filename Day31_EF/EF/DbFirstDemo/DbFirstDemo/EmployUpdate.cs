using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDemo
{
    internal class EmployUpdate
    {
        static void Main()
        {
            EMp emp = new EMp();
            Console.WriteLine("Enter Employ Number  ");
            emp.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employ Name  ");
            emp.nam = Console.ReadLine();
            Console.WriteLine("Enter Department   ");
            emp.dept = Console.ReadLine();
            Console.WriteLine("Enter Designation  ");
            emp.desig = Console.ReadLine();
            Console.WriteLine("Enter Basic   ");
            emp.basic = Convert.ToInt32(Console.ReadLine());

            sqlpracticeEntities entities = new sqlpracticeEntities();
            EMp empFound = entities.EMps.Where(x => x.Empno == emp.Empno).FirstOrDefault<EMp>();

            empFound.nam = emp.nam;
            empFound.dept = emp.dept;
            empFound.desig = emp.desig;
            empFound.basic = emp.basic;

            entities.SaveChanges();
            Console.WriteLine("*** Record Updated ***");
        }
    }
}
