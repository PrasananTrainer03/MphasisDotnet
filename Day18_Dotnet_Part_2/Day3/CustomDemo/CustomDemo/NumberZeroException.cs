using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDemo
{
    internal class NumberZeroException : ApplicationException
    {
        public NumberZeroException() { }
        public NumberZeroException(string error) : base(error) { }
    }
}
