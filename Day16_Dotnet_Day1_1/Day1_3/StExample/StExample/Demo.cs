using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StExample
{
    internal class Demo
    {
        int a, b;
        Demo()
        {
            a = 5;
            b = 7;
        }

        Demo(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return "A value is  " + a + " B value  " + b;
        }
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();
            Console.WriteLine(obj1);

            Demo obj2 = new Demo(56, 23);
            Console.WriteLine(obj2);
        }
    }
}
