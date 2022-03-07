using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class SortingDemo
    {
        public void Demo()
        {
            ArrayList alist = new ArrayList();
            alist.Add("Yashwanth");
            alist.Add("Pinki");
            alist.Add("Arka");
            alist.Add("Sourabh");
            alist.Add("Nikhil");
            alist.Add("Spoorthi");

            alist.Sort();
            Console.WriteLine("Sorted List is   ");
            foreach(object ob in alist)
            {
                Console.WriteLine(ob);
            }
        }

        static void Main()
        {
            new SortingDemo().Demo();
        }
    }
}
