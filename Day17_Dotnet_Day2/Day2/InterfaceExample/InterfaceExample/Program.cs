using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface ITraining
    {
        void Name();
        void Email();
    }

    class Sarjan : ITraining
    {
        public void Email()
        {
            Console.WriteLine("Email is sarjan@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Name is Sarjan...");
        }
    }
    class SasiKumar : ITraining
    {
        public void Email()
        {
            Console.WriteLine("Email is Sasi@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Name is Sasikumar...");
        }
    }

    class Sonali : ITraining
    {
        public void Email()
        {
            Console.WriteLine("Email is sonali@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Name is Sonali...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ITraining[] arr = new ITraining[]
            {
                new Sonali(),
                new Sarjan(),
                new SasiKumar()
            };
            foreach(ITraining i in arr)
            {
                i.Name();
                i.Email();
            }
        }
    }
}
