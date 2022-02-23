using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadEx2
{
    internal class Demo
    {
        public int Sum()
        {
            return 5;
        }

        public int Sum(int x)
        {
            return x + 5;
        }
        public int Sum(int x,int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            Console.WriteLine("Sum w.r.t. Zero Arguments  " +obj.Sum());
            Console.WriteLine("Sum w.r.t. One Argument  " +obj.Sum(42));
            Console.WriteLine("Sum w.r.t. Two Arguments   " +obj.Sum(12,53));
        }
    }
}
