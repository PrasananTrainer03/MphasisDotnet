using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    public class VotingException : ApplicationException
    {
        public VotingException()
        {

        }

        public VotingException(string error):base(error)
        {

        }
    }
}
