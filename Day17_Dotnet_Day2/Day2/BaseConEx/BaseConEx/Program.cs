using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConEx
{
    class Employ
    {
        int empno;
        string name;
        double basic;

        public Employ(int empno,string name,double basic)
        {
            this.empno = empno; 
            this.name = name;
            this.basic= basic;
        }

        public override string ToString()
        {
            return "Employ No  " + empno + " Employ Name  " + name + " Salary  " + basic;
        }
    }

    class Amrut : Employ
    {
        public Amrut(int empno, string name, double basic) : base(empno, name, basic)
        {
        }
    }

    class Moumitha : Employ
    {
        public Moumitha(int empno, string name, double basic) : base(empno, name, basic)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ obj1 = new Moumitha(1, "Moumitha", 99234);
            Employ obj2 = new Amrut(2, "Amrut", 81244);

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}
