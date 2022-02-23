using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            str.Concat(" World");
            Console.WriteLine(str);

            string s1 = "Arka", s2 = "Naveen", s3 = "Prasad", s4 = "Arka";
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s4.GetHashCode());
        }
    }
}
