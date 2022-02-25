using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyDemo
{
    class Employ
    {
        int empno;
        string name;
        double basic;
        public int Empno
        {
            get { return empno; }
        }

        public string Name
        {
            get { return name; }
        }

        public double Basic
        {
            get { return basic; }
        }

        public Employ(int empno,string name,double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ employ1 = new Employ(1, "Arka", 99234);
            Console.WriteLine("Employ Number  " +employ1.Empno);
            Console.WriteLine("Employ Name  " +employ1.Name);
            Console.WriteLine("Salary   " +employ1.Basic);

            //employ1.Empno = 3;
        }
    }
}
