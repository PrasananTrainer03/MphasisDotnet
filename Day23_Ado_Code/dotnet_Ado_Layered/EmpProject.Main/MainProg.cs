using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Employ.BusinessLayer;
using Emp.Entities;
using Emp.Exceptions;
using System.Threading.Tasks;

namespace EmpProject.Main
{
    internal class MainProg
    {
        static EmpBAL bal;
        static MainProg()
        {
            bal = new EmpBAL();
        }

        public static void UpdateEmployMain()
        {
            Emp.Entities.Emp emp = new Emp.Entities.Emp();
            Console.WriteLine("Enter Employ No...");
            emp.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name  ");
            emp.Nam = Console.ReadLine();
            Console.WriteLine("Enter Department  ");
            emp.Dept = Console.ReadLine();
            Console.WriteLine("Enter Designation  ");
            emp.Desig = Console.ReadLine();
            Console.WriteLine("Enter Basic  ");
            emp.Basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bal.UpdateEmpBal(emp));
        }
        public static void DeleteEmployMain()
        {
            int empno;
            Console.WriteLine("Enter Employ Number   ");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bal.DeleteEmpBal(empno));
        }
        public static void AddEmployMain()
        {
            Emp.Entities.Emp emp = new Emp.Entities.Emp();
            Console.WriteLine("Enter Name  ");
            emp.Nam = Console.ReadLine();
            Console.WriteLine("Enter Department  ");
            emp.Dept = Console.ReadLine();
            Console.WriteLine("Enter Designation  ");
            emp.Desig = Console.ReadLine();
            Console.WriteLine("Enter Basic  ");
            emp.Basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bal.AddEmpBal(emp));
        }
        public static void SearchEmployMain()
        {
            int empno;
            Console.WriteLine("Enter Employ Number   ");
            empno = Convert.ToInt32(Console.ReadLine());
            Emp.Entities.Emp empFound = bal.SearchEmployBal(empno);
            if (empFound!=null)
            {
                Console.WriteLine(empFound);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
        public static void ShowEmployMain()
        {
            List<Emp.Entities.Emp> employList = bal.ShowEmployBal();

            foreach(Emp.Entities.Emp e in employList)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("O P T I O N S");
                Console.WriteLine("---------------");
                Console.WriteLine("1. Show Employ");
                Console.WriteLine("2. Search Employ");
                Console.WriteLine("3. Add Employ");
                Console.WriteLine("4. Update Employ");
                Console.WriteLine("5. Delete Employ");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter Your Choice   ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        ShowEmployMain();
                        break;
                    case 2:
                        SearchEmployMain();
                        break;
                    case 3:
                        try
                        {
                            AddEmployMain();
                        }
                        catch (Emp.Exceptions.EmployException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            UpdateEmployMain();
                        }
                        catch (Emp.Exceptions.EmployException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        DeleteEmployMain();
                        break;
                    case 6:
                        return;
                }
            } while (choice != 6);
        }
    }
}
