using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployCrudExamples
{
    internal class EmployDAO
    {
       static List<Employ> employList;

        static EmployDAO()
        {
            employList = new List<Employ>();
        }

        public string UpdateEmploy(Employ employ)
        {
            Employ employFound = SearchEmploy(employ.Empno);
            if (employFound!=null)
            {
                foreach(Employ e in employList)
                {
                    if (e.Empno==employ.Empno)
                    {
                        e.Name = employ.Name;
                        e.Basic = employ.Basic;
                    }
                }
                return "Record Updated...";
            }
            return "Record Not Found...";
        }
        public string DeleteEmploy(int empno)
        {
            Employ employFound = SearchEmploy(empno);
            if (employFound!=null)
            {
                employList.Remove(employFound);
                return "Record Deleted...";
            }
            return "Record Not Found...";
        }
        public List<Employ> ShowEmploy()
        {
            return employList;
        }

        public Employ SearchEmploy(int empno)
        {
            Employ employFound = null;
            foreach(Employ e in employList)
            {
                if (e.Empno==empno)
                {
                    employFound = e;
                }
            }
            return employFound;
        }

        public string AddEmploy(Employ employ)
        {
            employList.Add(employ);
            return "Record Inserted...";
        }


    }
}
