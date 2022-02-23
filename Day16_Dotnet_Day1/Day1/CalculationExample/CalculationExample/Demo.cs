using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationExample
{
    internal class Demo
    {
        public void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Sub is  " +c);
        }

        public void  Mult(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Mult is  " +c);
        }
        public void Sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum is   " +c);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers    ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Demo obj = new Demo();
            obj.Sum(a, b);
            obj.Sub(a, b);
            obj.Mult(a, b);
        }
    }
}
