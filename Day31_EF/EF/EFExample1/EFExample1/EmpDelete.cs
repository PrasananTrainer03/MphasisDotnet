using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample1
{
    internal class EmpDelete
    {
        static void Main()
        {
            int empno;
            //sqlpracticeEntities1 entities = new sqlpracticeEntities1();
            Console.WriteLine("Enter Employ Number   ");
            empno = Convert.ToInt32(Console.ReadLine());
            sqlpracticeEntities1 entities = new sqlpracticeEntities1();
            EMp emp = entities.EMps.Where(x => x.Empno == empno).FirstOrDefault<EMp>();
            if (emp!=null)
            {
                entities.EMps.Remove(emp);
                entities.SaveChanges();
            }
        }
    }
}
