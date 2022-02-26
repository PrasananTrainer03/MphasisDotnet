using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbExample
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Welcome to .NET");
            Console.WriteLine(sb);
            sb.Append("\nFrom Mphasis");
            Console.WriteLine(sb);
            sb.Remove(1, 10);
            Console.WriteLine(sb);
        }
    }
}
