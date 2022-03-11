using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDemo
{
    internal class Sp1
    {
        static void Main()
        {
            practicespEntities entities = new practicespEntities();
            var result = entities.prcEmployShow().Select(x => x);
            foreach(var v in result)
            {
                Console.WriteLine("Employ No   " + v.Empno);
                Console.WriteLine("Employ Name   " + v.Name);
                Console.WriteLine("Department   " + v.Dept);
                Console.WriteLine("Designation   " + v.Desig);
                Console.WriteLine("Basic   " + v.Basic);
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
