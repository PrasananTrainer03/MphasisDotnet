using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrMethods
{
    internal class Demo
    {
        public void Show()
        {
            string str = "Welcome to Dotnet Programminng...from Prasanna";
            Console.WriteLine("Length of String is  " +str.Length);
            Console.WriteLine("First Occurrence of char 'o' is  " +str.IndexOf("o"));
            string s1 = "Arka", s2 = "Naveen", s3 = "Arka";
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s1.CompareTo(s3));

            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s2.ToLower());
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.Show();
        }
    }
}
