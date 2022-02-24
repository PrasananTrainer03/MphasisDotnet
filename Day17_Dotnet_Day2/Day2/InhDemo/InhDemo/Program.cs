using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhDemo
{
    class First
    {
        public void Show()
        {
            Console.WriteLine("Show Method from class First...");
        }
    }

    class Second : First
    {
        public void Display()
        {
            Console.WriteLine("Display Method from Class Second...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Second obj = new Second();
            obj.Show();
            obj.Display();
        }
    }
}
