using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsConEx
{
    abstract class Employ
    {
        int empno;
        string name;
        double basic;

        public Employ(int empno, string name, double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }

        public override string ToString()
        {
            return "Employ No " + empno + " Name  " + name + " Basic  " + basic;
        }
    }

    class Arka : Employ
    {
        public Arka(int empno, string name, double basic) : base(empno, name, basic)
        {
        }
    }

    class Sindhu : Employ
    {
        public Sindhu(int empno, string name, double basic) : base(empno, name, basic)
        {
        }
    }

    class Sourav : Employ
    {
        public Sourav(int empno, string name, double basic) : base(empno, name, basic)
        {

        }
    }

    internal class Demo
    {
        static void Main(string[] args)
        {
            //Employ e1 = new Employ(1, "abc", 422333);
            //Employ e1 = new Sourav();
            //Employ e2 = new Arka(1);
            //Employ e3 = new Sindhu();
            Employ[] arrEmploy = new Employ[]
            {
                new Sourav(1,"Sourav",92445),
                new Arka(2,"Arka Mitra",92122),
                new Sindhu(3,"Sindhu",91133)
            };

            Console.WriteLine("Employ List   ");
            foreach(Employ e in arrEmploy)
            {
                Console.WriteLine(e);
            }
        }
    }
}
