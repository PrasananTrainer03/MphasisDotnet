using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SortEmploy
    {
        public void Sorting()
        {
            ArrayList alist = new ArrayList();
            alist.Add(new Employ { Empno = 1, Name = "Saurabh", Basic = 93844 });
            alist.Add(new Employ { Empno = 2, Name = "Mitra", Basic = 88124 });
            alist.Add(new Employ { Empno = 3, Name = "Joash", Basic = 94422 });
            alist.Add(new Employ { Empno = 4, Name = "Durga Prasad", Basic = 89044 });
            alist.Add(new Employ { Empno = 5, Name = "Naveen", Basic = 81814 });
            alist.Add(new Employ { Empno = 6, Name = "Pranesh", Basic = 86755 });

            //alist.Sort(new NameComparer());
            alist.Sort(new BasicComparer());
            Console.WriteLine("Sorted List  ");
            foreach(object ob in alist)
            {
                Employ e = (Employ)ob;
                Console.WriteLine(e);
            }
        }
        static void Main()
        {
            new SortEmploy().Sorting();
        }
    }
}
