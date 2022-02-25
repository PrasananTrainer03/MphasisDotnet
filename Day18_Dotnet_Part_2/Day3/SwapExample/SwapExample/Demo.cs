using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapExample
{
    class Data<T>
    {
        public void Swap(ref T a, ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }
    }
    internal class Demo
    {
     
        static void Main(string[] args)
        {
            Data<int> obj = new Data<int>();
            int a = 5, b = 7;
            obj.Swap(ref a, ref b);
            
            Console.WriteLine("A value "+a+ " B value  " +b);
            Data<string> obj1 = new Data<string>();
            string s1 = "Rakesh", s2 = "Amrut";
            obj1.Swap(ref s1, ref s2);
            Console.WriteLine(s1 + "   " +s2);
            double d1 = 12.5, d2 = 7.5;
            Data<double> obj3 = new Data<double>();
            obj3.Swap(ref d1, ref d2);
            Console.WriteLine(d1 + "   " +d2);
        }
    }
}
