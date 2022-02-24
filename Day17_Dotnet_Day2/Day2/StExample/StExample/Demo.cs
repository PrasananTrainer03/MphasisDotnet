using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StExample
{
    class Data
    {
        public void Show()
        {
            Console.WriteLine("Show Method from Data class...");
        }

        public static void Display()
        {
            Console.WriteLine("Display Method from Data Class...");
        }
    }
    internal class Demo
    {
        static void Main(string[] args)
        {
            Data.Display();
            Data obj = new Data();
            obj.Show();
        }
    }
}
