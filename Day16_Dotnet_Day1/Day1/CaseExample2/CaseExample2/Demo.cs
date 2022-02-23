using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseExample2
{
    internal class Demo
    {
        public void Show(string dayName)
        {
            switch(dayName)
            {
                case "Monday":
                    Console.WriteLine("Hi Its Monday...");
                    break;
                case "Tuesday":
                    Console.WriteLine("Its Tuesday...");
                    break;
                case "Wednesday":
                    Console.WriteLine("Its Wednesday...");
                    break;
                case "Thursday":
                    Console.WriteLine("Its Thursday...");
                    break;
                case "Friday":
                    Console.WriteLine("Its Friday...");
                    break;
                case "Saturday":
                    Console.WriteLine("Its Saturday...");
                    break;
                default:
                    Console.WriteLine("Its Invalid Day...");
                    break;
            }
        }
        static void Main(string[] args)
        {
            string dayName;
            Console.WriteLine("Enter DayName   ");
            dayName = Console.ReadLine();
            Demo obj = new Demo();
            obj.Show(dayName);
        }
    }
}
