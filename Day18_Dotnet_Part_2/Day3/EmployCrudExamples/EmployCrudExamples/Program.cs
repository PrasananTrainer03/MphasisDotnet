using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployCrudExamples
{
    internal class Program
    {
        static EmployDAO dao;
        static Program()
        {
            dao = new EmployDAO();
        }
        public static void AddEmploy()
        {
            Employ employ = new Employ();
            Console.WriteLine("Enter Employ Number   ");
            employ.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employ Name   ");
            employ.Name = Console.ReadLine();
            Console.WriteLine("Enter Basic   ");
            employ.Basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(dao.AddEmploy(employ));
        }

        public static void UpdateEmploy()
        {
            Employ employ = new Employ();
            Console.WriteLine("Enter Employ Number   ");
            employ.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employ Name   ");
            employ.Name = Console.ReadLine();
            Console.WriteLine("Enter Basic   ");
            employ.Basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(dao.UpdateEmploy(employ));
        }

        public static void ShowEmploy()
        {
            List<Employ> employList = dao.ShowEmploy();
            foreach(Employ e in employList)
            {
                Console.WriteLine(e);
            }
        }

        public static void DeleteEmploy()
        {
            int empno;
            Console.WriteLine("Enter Employ No   ");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dao.DeleteEmploy(empno));
        }

        public static void SearchEmploy()
        {
            int empno;
            Console.WriteLine("Enter Employ No   ");
            empno = Convert.ToInt32(Console.ReadLine());
            Employ employFound = dao.SearchEmploy(empno);
            if (employFound!=null)
            {
                Console.WriteLine(employFound);
            } else
            {
                Console.WriteLine("Record Not Found...");
            }
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
               
                Console.WriteLine("O P T I O N S");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add Employ");
                Console.WriteLine("2. Show Employ");
                Console.WriteLine("3. Search Employ");
                Console.WriteLine("4. Delete Employ");
                Console.WriteLine("5. Update Employ");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter Choice   ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1: 
                            AddEmploy();
                            break;
                    case 2:
                            ShowEmploy();
                            break;
                    case 3:
                        SearchEmploy();
                        break;
                    case 4:
                        DeleteEmploy();
                        break;
                    case 5:
                        UpdateEmploy();
                        break;
                    case 6: return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }    
            } while (choice != 6);
        }
    }
}
