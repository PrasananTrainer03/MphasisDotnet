using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Employ.Entities;
using Employ.Exceptions;
using Employ.BusinessLayer;
using System.Threading.Tasks;

namespace Employ.Main
{
    internal class Program
    {
        static EmployBAL bal;
        static Program()
        {
            bal = new EmployBAL();
        }

        public static void UpdateEmployMain()
        {
            Emp emp = new Emp();
            Console.WriteLine("Enter Employ No   ");
            emp.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employ Name  ");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Employ Basic   ");
            emp.Basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bal.UpdateEmployBAL(emp));
        }

        public static void AddEmployMain()
        {
            Emp emp = new Emp();
            Console.WriteLine("Enter Employ No   ");
            emp.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employ Name  ");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Employ Basic   ");
            emp.Basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bal.AddEmployBAL(emp));
        }

        public static void ShowEmployMain()
        {
            List<Emp> employList = bal.ShowEmployBal();
            foreach(Emp e in employList)
            {
                Console.WriteLine(e);
            }
        }

        public static void DeleteEmployMain()
        {
            int empno;
            Console.WriteLine("Enter Employ No   ");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bal.DeleteEmployBal(empno));
        }
        public static void SearchEmployMain()
        {
            int empno;
            Console.WriteLine("Enter Employ No   ");
            empno = Convert.ToInt32(Console.ReadLine());
            Emp emp = bal.SearchEmployBal(empno);
            if (emp!=null)
            {
                Console.WriteLine(emp);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("O P T I O N S");
                Console.WriteLine("---------------");
                Console.WriteLine("1. Add Employ");
                Console.WriteLine("2. Search Employ");
                Console.WriteLine("3. Show Employ");
                Console.WriteLine("4. Updae Employ");
                Console.WriteLine("5. Delete Employ");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter Your Choice   ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        try
                        {
                            AddEmployMain();
                        }
                        catch(EmployException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 2:
                        SearchEmployMain();
                        break;
                    case 3:
                        ShowEmployMain();
                        break;
                    case 5:
                        DeleteEmployMain();
                        break;
                    case 4:
                        try
                        {
                            UpdateEmployMain();
                        }
                        catch(EmployException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 6);
        }
    }
}
