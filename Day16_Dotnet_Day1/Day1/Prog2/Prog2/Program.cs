using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2
{
    class Demo
    {
        public void Satabdi()
        {
            Console.WriteLine("Hi I am Sushree satabdi...");
        }

        internal void Pranesh()
        {
            Console.WriteLine("Hi I am Pranesh...");
        }

        private void Sarjan()
        {
            Console.WriteLine("Hi I am Sarjan Thapa...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.Satabdi();
            demo.Pranesh();
        }
    }
}
