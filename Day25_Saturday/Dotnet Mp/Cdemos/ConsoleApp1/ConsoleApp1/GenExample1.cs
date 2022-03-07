using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenExample1
    {
        static void Main()
        {
            List<string> names = new List<string>();
            names.Add("Arka");
            //names.Add(2);
            names.Add("yashwanth");
            names.Add("Kalyan");
            names.Add("Akhil");
            names.Add("Srikar");
            Console.WriteLine("Names are  ");
            foreach(string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}
