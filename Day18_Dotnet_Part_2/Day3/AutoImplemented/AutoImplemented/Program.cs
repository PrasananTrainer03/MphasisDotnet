using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplemented
{
    class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ emp1 = new Employ();
            emp1.Empno = 1;
            emp1.Name = "Raj Kishore";
            emp1.Dept = "Dotnet";

            Console.WriteLine("Employ Number  " +emp1.Empno);
            Console.WriteLine("Employ Name   " +emp1.Name);
            Console.WriteLine("Department   " +emp1.Dept);
        }
    }
}
