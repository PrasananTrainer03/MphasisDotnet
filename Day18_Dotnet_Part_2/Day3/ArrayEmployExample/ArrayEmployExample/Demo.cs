using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEmployExample
{
    class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }

        public override string ToString()
        {
            return "Employ No  " + Empno + " Employ Name  " + Name + " Basic  " + Basic;
        }
    }
    internal class Demo
    {
        static void Main(string[] args)
        {
            Employ[] arrEmploy = new Employ[]
            {
                new Employ{Empno=1,Name="Amrut",Basic=88234},
                new Employ{Empno=2,Name="Nandini",Basic=91144},
                new Employ{Empno=3,Name="Peraiah",Basic=76843},
                new Employ{Empno=4,Name="Sarjan",Basic=90884},
                new Employ{Empno=5,Name="Sandhya",Basic=67844},
            };

            Console.WriteLine("Employ List   ");
            foreach(Employ e in arrEmploy)
            {
                Console.WriteLine(e);
            }
        }
    }
}
