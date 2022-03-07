using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class EmploySearch
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

            Console.WriteLine("Enter Employ Number    ");
            int empno = Convert.ToInt32(Console.ReadLine());
            Employ employ = employList.Where(x => x.Empno == empno).SingleOrDefault<Employ>();
            if (employ!=null)
            {
                Console.WriteLine(employ);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
    }
}
