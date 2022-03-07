using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NameGenComparer : IComparer<Employ>
    {
        public int Compare(Employ e1, Employ e2)
        {
            return e1.Name.CompareTo(e1.Name);
        }
    }
}
