using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayListExample
    {
        public void Show()
        {
            ArrayList alist = new ArrayList();
            alist.Add("Arka Mitra");
            alist.Add("Yashwanth");
            alist.Add("Moumitha");
            alist.Add("Rajesh");
            alist.Add("Spoorthi");

            foreach(object ob in alist)
            {
                Console.WriteLine(ob);
            }
        }
        static void Main(string[] args)
        {
            new ArrayListExample().Show();
        }
    }
}
