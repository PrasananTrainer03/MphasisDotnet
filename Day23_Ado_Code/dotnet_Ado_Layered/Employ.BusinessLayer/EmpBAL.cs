using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emp.DAO;
using Emp.Entities;
using Emp.Exceptions;
using System.Threading.Tasks;

namespace Employ.BusinessLayer
{
    public class EmpBAL
    {
        static EmpDAO dao;
        static StringBuilder sb;

        public string UpdateEmpBal(Emp.Entities.Emp emp)
        {
            if (ValidateEmp(emp) == true)
            {
                return dao.UpdateEmployDao(emp);
            }
            throw new Emp.Exceptions.EmployException(sb.ToString());
        }
        public string DeleteEmpBal(int empno)
        {
            return dao.DeleteEmployDao(empno);
        }
        public string AddEmpBal(Emp.Entities.Emp emp)
        {
            if (ValidateEmp(emp)==true)
            {
                return dao.AddEmployDao(emp);
            }
            throw new Emp.Exceptions.EmployException(sb.ToString());
        }
        public static bool ValidateEmp(Emp.Entities.Emp emp)
        {
            bool isValid = true;
            if (emp.Nam.Length < 5)
            {
                sb.Append("Employ name Contains min 5 characters...\r\n");
                isValid = false;
            }
            if (emp.Basic < 20000 || emp.Basic > 100000)
            {
                sb.Append("Basic Must be from 20000 to 100000...\r\n");
                isValid = false;
            }
            return isValid;
        }
        static EmpBAL()
        {
            dao = new EmpDAO();
            sb = new StringBuilder();
        }
        public List<Emp.Entities.Emp> ShowEmployBal()
        {
            return dao.ShowEmployDao();
        }

        public Emp.Entities.Emp SearchEmployBal(int empno)
        {
            return dao.SearchEmpDao(empno);
        }
    }
}
