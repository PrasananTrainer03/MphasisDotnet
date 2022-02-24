using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=12;
            double b=12.5;
            string name = "Mphasis";

            /* Implemeting Boxing */
            object ob1 = a;
            object ob2 = b;
            object ob3 = name;

            /* Implemeting Unboxing */

            int a1 = (Int32)ob1;
            double b1 = (Double)ob2;
            string str = (string)ob3;
            Console.WriteLine(a1);
            Console.WriteLine(b1);
            Console.WriteLine(str);
        }
    }
}
