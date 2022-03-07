using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Employ Records are  ");
            var result = from ob in employList select ob;
            foreach(var v in result)
            {
                Console.WriteLine("Employ No  " +v.Empno);
                Console.WriteLine("Employ Name  " +v.Name);
                Console.WriteLine("Department   " +v.Dept);
                Console.WriteLine("Designation   " +v.Desig);
                Console.WriteLine("Basic   " +v.Basic);
                Console.WriteLine("----------------------------------------");
            }
            /* Project Operator */

            var result1 = from ob in employList select new {ob.Empno,ob.Name,ob.Basic };
            Console.WriteLine("Projected Fields are   ");
            foreach(var v in result1)
            {
                Console.WriteLine("Employ No   " +v.Empno);
                Console.WriteLine("Employ Name   " +v.Name);
                Console.WriteLine("Basic   " +v.Basic);
                Console.WriteLine("----------------------------------------------");
            }

            var result2 = from ob in employList where ob.Basic >= 90000 select ob;
            Console.WriteLine("Filtered Records are   ");
            foreach(var v in result2)
            {
                Console.WriteLine("Employ No  " + v.Empno);
                Console.WriteLine("Employ Name  " + v.Name);
                Console.WriteLine("Department   " + v.Dept);
                Console.WriteLine("Designation   " + v.Desig);
                Console.WriteLine("Basic   " + v.Basic);
                Console.WriteLine("----------------------------------------");
            }

            var result3 = from ob in employList orderby ob.Name select ob;
            Console.WriteLine("Sorted Data  ");
            foreach(var v in result3)
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
