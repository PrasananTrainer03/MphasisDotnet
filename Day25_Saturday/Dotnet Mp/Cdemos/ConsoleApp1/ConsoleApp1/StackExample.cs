using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StackExample
    {
        public void StatckDemo()
        {
            Stack obj = new Stack();
            obj.Push("Bhargav");
            obj.Push("Arka");
            obj.Push("Ashok");
            obj.Push("Pinki");
            obj.Push("Nikhil");
            foreach(object ob in obj)
            {
                Console.WriteLine(ob);
            }
            obj.Pop();
            obj.Pop();
            Console.WriteLine("List after Pop Operation...");
            foreach(object ob in obj)
            {
                Console.WriteLine(ob);
            }
        }
        static void Main()
        {
            new StackExample().StatckDemo();
        }
    }
}
