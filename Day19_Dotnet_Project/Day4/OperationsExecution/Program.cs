using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clsOperations;
using System.Threading.Tasks;

namespace OperationsExecution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number   ");
            int n = Convert.ToInt32(Console.ReadLine());
            Test obj = new Test();
            Console.WriteLine("Factorial Value  " +obj.Fact(n));
            Console.WriteLine(obj.EvenOdd(n));
        }
    }
}
