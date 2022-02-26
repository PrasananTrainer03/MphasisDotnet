using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsOperations
{
    public class Test
    {
        public int Fact(int n)
        {
            if (n <=0)
            {
                return 1;
            } else
            {
                return n * Fact(n - 1);
            }
        }

        public string EvenOdd(int n)
        {
            if (n%2==0)
            {
                return "Even Number...";
            }
            else
            {
                return "Odd Number...";
            }
        }
    }
}
