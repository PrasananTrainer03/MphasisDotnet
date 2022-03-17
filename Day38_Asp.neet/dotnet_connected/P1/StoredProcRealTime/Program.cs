using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcRealTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployDAO dao = new EmployDAO();
            List<Employ> employList = dao.ShowEmploy();
            foreach(Employ employ in employList)
            {
                Console.WriteLine(employ);
            }
        }
    }
}
