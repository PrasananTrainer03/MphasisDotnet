using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    internal class Employ
    {
        int empno;
        string name;
        double basic;

        public override string ToString()
        {
            return "Employ No " + empno + " Name " + name + " Basic " + basic;
        }
        static void Main(string[] args)
        {
            Employ e1 = new Employ();
            e1.empno = 1;
            e1.name = "Arka Mitra";
            e1.basic = 84823;

            Employ e2 = new Employ();
            e2.empno = 2;
            e2.name = "Naveen";
            e2.basic = 99112;

            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
    }
}
