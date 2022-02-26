using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clsCalculation;
using System.Threading.Tasks;

namespace CalculationExecution
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculation obj = new Calculation();
            Console.WriteLine("Sum is  " +obj.Sum(a,b));
            Console.WriteLine("Sub is  " +obj.Sub(a,b));
            Console.WriteLine("Mult is  " +obj.Mult(a,b));

        }
    }
}
