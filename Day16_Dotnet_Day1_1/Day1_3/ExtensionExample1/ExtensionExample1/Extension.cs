using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExample1
{
    internal static class Extension
    {
        public static int Mult(this Calculation c, int x,int y)
        {
            return x * y;
        }
    }
}
