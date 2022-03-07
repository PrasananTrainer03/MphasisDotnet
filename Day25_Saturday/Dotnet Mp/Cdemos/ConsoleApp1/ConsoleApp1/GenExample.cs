using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Example<T>
    {
        public void Swap(ref T a,ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }
    }
    class GenExample
    {
        static void Main()
        {
            int a, b;
            a = 5;
            b = 3;
            Example<int> obj1 = new Example<int>();
            obj1.Swap(ref a, ref b);
            Console.WriteLine("A value  " +a+ " B Value  " +b);
            string s1 = "Arka", s2 = "Yashwanth";
            Example<string> obj2 = new Example<string>();
            obj2.Swap(ref s1, ref s2);
            Console.WriteLine(s1 + "  " +s2);
            bool b1 = true, b2 = false;
            Example<bool> obj3 = new Example<bool>();
            obj3.Swap(ref b1, ref b2);
            Console.WriteLine(b1 + "            " +b2);
        }
    }
}
