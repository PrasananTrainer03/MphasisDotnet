using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Employ.Entities;
using Employ.Exceptions;
using Employ.DataLayer;
using System.Threading.Tasks;

namespace Employ.BusinessLayer
{
    public class EmployBAL
    {
        static StringBuilder sb;
        static EmployDAL dal;
        static EmployBAL()
        {
            sb = new StringBuilder();
            dal = new EmployDAL();
        }

        public string DeleteEmployBal(int empno)
        {
            return dal.DeleteEmployDAO(empno);
        }
        public Emp SearchEmployBal(int empno)
        {
            return dal.SearchEmployDAO(empno);
        }

        public List<Emp> ShowEmployBal()
        {
            return dal.ShowEmployDAO();
        }

        public string UpdateEmployBAL(Emp emp)
        {
            if (ValidateEmploy(emp)==true)
            {
                return dal.UpdateEmployDAO(emp);
            }
            else
            {
                throw new EmployException(sb.ToString());
            }
        }
        public string AddEmployBAL(Emp emp)
        {
            if (ValidateEmploy(emp)==true)
            {
                return dal.AddEmployDAO(emp);
            }
            else
            {
                throw new EmployException(sb.ToString());
            }
        }
        public bool ValidateEmploy(Emp emp)
        {
            bool isValid = true;
            if (emp.Empno <= 0)
            {
                sb.Append("Employ No cannot be zero or Negative...\n");
                isValid = false;
            }
            if (emp.Name.Length < 5)
            {
                sb.Append("Employ name cannot be less than 5 characters...\n");
                isValid = false;
            }
            if (emp.Basic < 5000 || emp.Basic > 80000)
            {
                sb.Append("Basic Must be between 5000 and 80000");
                isValid = false;
            }
            return isValid;
        }

    }
}
