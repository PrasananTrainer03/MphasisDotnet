using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Employ emp1 = (Employ)x;
            Employ emp2 = (Employ)y;
            return emp2.Name.CompareTo(emp1.Name);
        }
    }
}
