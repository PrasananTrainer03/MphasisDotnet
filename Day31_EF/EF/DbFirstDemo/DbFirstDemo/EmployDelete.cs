using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDemo
{
    internal class EmployDelete
    {
        static void Main()
        {
            int empno;
            Console.WriteLine("Enter Employ Number   ");
            empno = Convert.ToInt32(Console.ReadLine());
            sqlpracticeEntities entities = new sqlpracticeEntities();
            EMp emp = entities.EMps.Where(x => x.Empno == empno).FirstOrDefault<EMp>();
            entities.EMps.Remove(emp);
            entities.SaveChanges();
            Console.WriteLine("*** Record Deleted ***");
        }
    }
}
