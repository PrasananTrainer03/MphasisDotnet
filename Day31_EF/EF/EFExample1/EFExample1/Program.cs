using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sqlpracticeEntities1 entites = new sqlpracticeEntities1();

            var result1 = from em in entites.EMps select em;
            Console.WriteLine("Employ records are  ");
            foreach(var v in result1)
            {
                Console.WriteLine("Employ No  " +v.Empno + "\n Employ Name " +v.nam +
                        " Department  " +v.dept + " Designation  " +v.desig + 
                        " Basic   " +v.basic);
                
            }
        }
    }
}
