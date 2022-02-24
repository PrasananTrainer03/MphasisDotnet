using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    interface IOne
    {
        void Show();
    }
    interface ITwo
    {
        void Show();
    }
    interface IThree
    {
        void Show();
    }

    class Demo : IOne, ITwo, IThree
    {
        void IOne.Show()
        {
            Console.WriteLine("Show Method w.r.t. Interface One");
        }

        void ITwo.Show()
        {
            Console.WriteLine("Show Method w.r.t. Interface Two");
        }

        void IThree.Show()
        {
            Console.WriteLine("Show Method w.r.t. Interface Three");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IOne obj1 = new Demo();
            ITwo obj2 = new Demo();
            IThree obj3 = new Demo();
            obj1.Show();
            obj2.Show();
            obj3.Show();
        }
    }
}
