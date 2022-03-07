using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenSort
    {
        static void Main()
        {
            new GenSort().Sorting();
        }
        public void Sorting()
        {
            List<Employ> alist = new List<Employ>();
            alist.Add(new Employ { Empno = 1, Name = "Saurabh", Basic = 93844 });
            alist.Add(new Employ { Empno = 2, Name = "Mitra", Basic = 88124 });
            alist.Add(new Employ { Empno = 3, Name = "Joash", Basic = 94422 });
            alist.Add(new Employ { Empno = 4, Name = "Durga Prasad", Basic = 89044 });
            alist.Add(new Employ { Empno = 5, Name = "Naveen", Basic = 81814 });
            alist.Add(new Employ { Empno = 6, Name = "Pranesh", Basic = 86755 });

            //alist.Sort(new NameComparer());

            alist.Sort(new NameGenComparer());

            Console.WriteLine("Sorted List  ");
            foreach(Employ e in alist)
            {
                Console.WriteLine(e);
            }
        }
    }
}
