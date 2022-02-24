using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsDemo
{
    abstract class Training
    {
        public abstract void Name();
        public abstract void Email();
    }

    class Sandhya : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is sandhya@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Name is Sandhya...");
        }
    }

    class Madhusree : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is madhushree@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Name is Madhushree...");
        }
    }
    class Bhargav : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is BhargavKrishna@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Name is Bhargav Krishna...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Training[] arr = new Training[]
            {
                new Bhargav(),new Sandhya(),new Madhusree()
            };
            foreach(Training t in arr)
            {
                t.Name();
                t.Email();
            }
        }
    }
}
