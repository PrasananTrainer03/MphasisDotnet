using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StDemo
{
    static class Example
    {
        public static void Display()
        {
            Console.WriteLine("From Display Method...");
        }

        public static void Show()
        {
            Console.WriteLine("From Show Method...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Example.Display();
            Example.Show();
        }
    }
}
