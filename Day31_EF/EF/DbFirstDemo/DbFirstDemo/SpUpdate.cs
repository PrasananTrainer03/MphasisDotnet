using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDemo
{
    internal class SpUpdate
    {
        static void Main()
        {
            int empno;
            Console.WriteLine("Enter Employ Number  ");
            empno = Convert.ToInt32(Console.ReadLine());
            practicespEntities entities = new practicespEntities();
            entities.prcEmployDelete(empno);
            Console.WriteLine("*** Record Deleted ***");
        }
    }
}
