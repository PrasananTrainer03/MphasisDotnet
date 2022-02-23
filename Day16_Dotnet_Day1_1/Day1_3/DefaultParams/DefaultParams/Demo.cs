using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParams
{
    internal class Demo
    {
        public void Show(string firstName, string lastName, string company="Mphasis")
        {
            Console.WriteLine("First Name  " +firstName);
            Console.WriteLine("Last Name  " +lastName);
            Console.WriteLine("Company  " + company) ;
        }
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();
            obj1.Show("Santosh", "Kumar");
            obj1.Show("Manoj", "Aneena", "Hexaware");
        }
    }
}
