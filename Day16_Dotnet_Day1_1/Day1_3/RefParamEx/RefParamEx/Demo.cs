using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefParamEx
{
    internal class Demo
    {
        public void Incr(ref int x)
        {
            x++;
        }
        static void Main(string[] args)
        {
            int x = 12;
            Demo obj = new Demo();
            obj.Incr(ref x);
            Console.WriteLine("X value is   " +x);
        }
    }
}
