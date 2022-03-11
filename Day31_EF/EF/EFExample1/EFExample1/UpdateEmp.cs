using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample1
{
    internal class UpdateEmp
    {
        static void Main()
        {
            EMp emp = new EMp();
            Console.WriteLine("Enter Employ No   ");
            emp.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employo Name   ");
            emp.nam = Console.ReadLine();
            Console.WriteLine("Enter Department  ");
            emp.dept = Console.ReadLine();
            Console.WriteLine("Enter Designation  ");
            emp.desig = Console.ReadLine();
            Console.WriteLine("Enter Basic   ");
            emp.basic = Convert.ToInt32(Console.ReadLine());

            sqlpracticeEntities1 entities = new sqlpracticeEntities1();
            EMp empFound = entities.EMps.Where(x => x.Empno == emp.Empno).FirstOrDefault<EMp>();
            if (empFound!=null)
            {
                empFound.nam = emp.nam;
                empFound.dept = emp.dept;
                empFound.desig = emp.desig;
                empFound.basic = emp.basic;
                entities.SaveChanges();
                Console.WriteLine("*** record updated ***");
            }
        }
    }
}
