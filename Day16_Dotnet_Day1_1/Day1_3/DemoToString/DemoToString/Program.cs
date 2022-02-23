using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.sno = 1;
            s1.name = "Sakshi";
            s1.city = "Delhi";
            s1.cgp = 9.2;

            Student s2 = new Student();
            s2.sno = 3;
            s2.name = "Sanjay";
            s2.city = "Pune";
            s2.cgp = 9.1;

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
