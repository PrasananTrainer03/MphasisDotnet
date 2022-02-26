using System;
using System.Collections.Generic;
using System.Linq;
using Employ.Entities;
using System.Text;
using System.Threading.Tasks;

namespace Employ.DataLayer
{
    public class EmployDAL
    {
        static List<Emp> employList;

        static EmployDAL()
        {
            employList = new List<Emp>();
        }

        public List<Emp> ShowEmployDAO()
        {
            return employList;
        }

        public string UpdateEmployDAO(Emp emp)
        {
            Emp empFound = SearchEmployDAO(emp.Empno);
            if (empFound!=null)
            {
                foreach (Emp e in employList)
                {
                    if (e.Empno == emp.Empno)
                    {
                        e.Name = emp.Name;
                        e.Basic = emp.Basic;
                    }
                }
                return "Employ Record Updated...";
            }
            return "Employ Record Not Found...";
        }

        public string DeleteEmployDAO(int empno)
        {
            Emp empFound = SearchEmployDAO(empno);
            if (empFound!=null)
            {
                employList.Remove(empFound);
                return "Employ Record Deleted...";
            }
            return "Employ Record Not Found...";
        }

        public string AddEmployDAO(Emp emp)
        {
            employList.Add(emp);
            return "Employ Record Inserted...";
        }

        public Emp SearchEmployDAO(int empno)
        {
            Emp employFound = null;
            foreach(Emp emp in employList)
            {
                if (emp.Empno==empno)
                {
                    employFound = emp;
                }
            }
            return employFound;
        }
    }
}
