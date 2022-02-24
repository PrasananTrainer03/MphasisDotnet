using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    internal class Demo
    {
        static int count;
        public void Incr()
        {
            count++;
        }

        public void Display()
        {
            Console.WriteLine("Count is  " +count);
        }
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();
            Demo obj2 = new Demo();
            Demo obj3 = new Demo();
            obj1.Incr();
            obj2.Incr();
            obj2.Incr();
            obj1.Display();
        }
    }
}
