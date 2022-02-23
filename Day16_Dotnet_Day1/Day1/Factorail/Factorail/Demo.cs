using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorail
{
    /// <summary>
    /// Program to Calculate factorial of given number
    /// </summary>
    internal class Demo
    {
        public void Calc(int n)
        {
            int f = 1, i = 1;
            while(i <= n)
            {
                f = f * i;
                i++;
            }
            Console.WriteLine("Factorial Value is   " +f);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter N value   ");
            n = Convert.ToInt32(Console.ReadLine());
            Demo obj = new Demo();
            obj.Calc(n);
        }
    }
}
