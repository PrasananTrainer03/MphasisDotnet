using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoRealTime
{
    internal class EmployShowAllMain
    {
        static void Main(string[] args)
        {
            EmpDAO dao = new EmpDAO();
            List<Emp> employList = dao.ShowEmploy();
            foreach(Emp e in employList)
            {
                Console.WriteLine(e);
            }
        }
    }
}
