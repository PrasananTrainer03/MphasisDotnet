using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDemo
{
    internal class NegativeException : ApplicationException
    {
        public NegativeException() { }

        public NegativeException(string error) : base(error)
        {

        }
    }
}
