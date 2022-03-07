using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BasicComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Employ emp1 = (Employ)x;
            Employ emp2 = (Employ)y;
            if (emp1.Basic >= emp2.Basic)
            {
                return 1; 
            } else
            {
                return -1;
            }
        }
    }
}
