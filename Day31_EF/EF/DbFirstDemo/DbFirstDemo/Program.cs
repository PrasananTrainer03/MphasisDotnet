using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sqlpracticeEntities entities = new sqlpracticeEntities();
            var result = entities.EMps.Select(x => x);
            Console.WriteLine("Employ Records are  ");
            foreach(var v in result)
            {
                Console.WriteLine("Employ No   " +v.Empno);
                Console.WriteLine("Employ Name  " +v.nam);
                Console.WriteLine("Department   " +v.dept);
                Console.WriteLine("Designation   " +v.desig);
                Console.WriteLine("Basic   " +v.basic);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
