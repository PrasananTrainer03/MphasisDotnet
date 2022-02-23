using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseExample1
{
    internal class Demo
    {
        public void Show(int n)
        {
            switch(n)
            {
                case 1:
                    Console.WriteLine("Hi I am Naveen...");
                    break;
                case 2:
                    Console.WriteLine("Hii I am Siva Prasad...");
                    break;
                case 3:
                    Console.WriteLine("Hi I am Moumitha Roy...");
                    break;
                case 4:
                    Console.WriteLine("Hi I am Jayasurya...");
                    break;
                case 5:
                    Console.WriteLine("Hi I am Madhushree...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice...");
                    break;
            }
        }
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter Your Choice   ");
            choice = Convert.ToInt32(Console.ReadLine());
            Demo obj = new Demo();
            obj.Show(choice);
        }
    }
}
