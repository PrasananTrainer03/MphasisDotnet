using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDemo
{
    internal class Sp2
    {
        static void Main()
        {
            practicespEntities entities = new practicespEntities();
            Console.WriteLine("Enter Employ Number   ");
            int empno = Convert.ToInt32(Console.ReadLine());
            var result = entities.prcEmploySearch(empno).Select(x => x);
            foreach(var v in result)
            {
                Console.WriteLine(v.Empno);
                Console.WriteLine(v.Name);
                Console.WriteLine(v.Dept);
                Console.WriteLine(v.Desig);
                Console.WriteLine(v.Basic);
            }
        }
    }
}