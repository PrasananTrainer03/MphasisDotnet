using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class LambdaExprEx1
    {
        static void Main()
        {
            List<Employ> employList = new List<Employ>()
            {
                new Employ{Empno=1,Name="Supriya",Dept="Dotnet",Desig="Programmer", Basic=92345},
                new Employ{Empno=2,Name="Amrut", Dept="Java",Desig="Manager", Basic=89443},
                new Employ{Empno=3,Name="Yashwanth", Dept="Angular",Desig="Manager",Basic=91144},
                new Employ{Empno=4,Name="Rakesh",Dept="Dotnet",Desig="Programmer", Basic=89087},
                new Employ{Empno=5,Name="Vasantha", Dept="Java",Desig="Manager", Basic=96645},
                new Employ{Empno=6,Name="Bhanu", Dept="Angular",Desig="Manager", Basic=87883},
            };

            // var result = from ob in employList select ob;
            var result1 = employList.Select(ob => ob);
            Console.WriteLine("Employ List is   ");
            foreach(var v in result1)
            {
                Console.WriteLine("Employ No  " + v.Empno);
                Console.WriteLine("Employ Name  " + v.Name);
                Console.WriteLine("Department   " + v.Dept);
                Console.WriteLine("Designation   " + v.Desig);
                Console.WriteLine("Basic   " + v.Basic);
                Console.WriteLine("----------------------------------------");
            }

            /* Apply PROJECT Operator */

            var result2 = employList.Select(x => new {x.Empno,x.Name,x.Basic });
            Console.WriteLine("Projected Fields (Lambda Expression)  ");
            foreach(var v in result2)
            {
                Console.WriteLine("Employ No   " + v.Empno);
                Console.WriteLine("Employ Name   " + v.Name);
                Console.WriteLine("Basic   " + v.Basic);
                Console.WriteLine("-------------------------------------");
            }

            var result3 = employList.Where(x => x.Basic >= 90000);
            Console.WriteLine("Filtered Records are   ");
            foreach(var v in result3)
            {
                Console.WriteLine("Employ No  " + v.Empno);
                Console.WriteLine("Employ Name  " + v.Name);
                Console.WriteLine("Department   " + v.Dept);
                Console.WriteLine("Designation   " + v.Desig);
                Console.WriteLine("Basic   " + v.Basic);
                Console.WriteLine("----------------------------------------");
            }

            var result4 = employList.OrderBy(x => x.Name);
            Console.WriteLine("List Sort By Name-wise Ascending order ");
            foreach(var v in result4)
            {
                Console.WriteLine("Employ No  " + v.Empno);
                Console.WriteLine("Employ Name  " + v.Name);
                Console.WriteLine("Department   " + v.Dept);
                Console.WriteLine("Designation   " + v.Desig);
                Console.WriteLine("Basic   " + v.Basic);
                Console.WriteLine("----------------------------------------");

            }

            var result5 = employList.OrderByDescending(x => x.Name);
            Console.WriteLine("Sort By Name-wise Descending Order");
            foreach(var v in result5)
            {
                Console.WriteLine("Employ No  " + v.Empno);
                Console.WriteLine("Employ Name  " + v.Name);
                Console.WriteLine("Department   " + v.Dept);
                Console.WriteLine("Designation   " + v.Desig);
                Console.WriteLine("Basic   " + v.Basic);
                Console.WriteLine("----------------------------------------");

            }
        }
    }
}
