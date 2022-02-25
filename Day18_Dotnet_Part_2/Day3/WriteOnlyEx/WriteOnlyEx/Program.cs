using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteOnlyEx
{
    class Employ
    {
        int empno;
        string name;
        double basic;

        public int Empno { set { empno = value; } }
        public string Name {  set { name = value; } }

        public double Basic { set { basic = value; } }

        public override string ToString()
        {
            return "Employ No  " + empno + " Employ Name  " + name + " Basic  " + basic;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ employ1 = new Employ();
            employ1.Empno = 1;
            employ1.Name = "Raj";
            employ1.Basic = 99234;

         //   Console.WriteLine(employ1.Empno);

            Console.WriteLine(employ1);
        }
    }
}
