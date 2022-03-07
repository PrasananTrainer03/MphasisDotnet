using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NvcEx
    {
        public void Demo()
        {
            NameValueCollection nvc = new NameValueCollection();
            string[] values = null;
            nvc.Add("Arka", "Mitra");
            nvc.Add("Arka", "Dotnet");
            nvc.Add("Rakesh", "Mishra");
            nvc.Add("Abhishek", "Anand");
            nvc.Add("Sakshi", "Mishra");
            nvc.Add("Naveen", "Koduru");
            nvc.Add("Naveen", "Tirupathi");
            foreach(string key in nvc.Keys)
            {
                values = nvc.GetValues(key);
                foreach(string value in values)
                {
                    Console.WriteLine(key +   "   " + value);
                }
            }
        }
        static void Main()
        {
            new NvcEx().Demo();
        }
    }
}
