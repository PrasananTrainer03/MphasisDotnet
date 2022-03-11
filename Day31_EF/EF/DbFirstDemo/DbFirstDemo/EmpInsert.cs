using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Core.Objects;
using System.Threading.Tasks;

namespace DbFirstDemo
{
    internal class EmpInsert
    {
        static void Main()
        {
            practicespEntities entities = new practicespEntities();
            int empno;
            int basic;
            string name, dept, desig;
            //Console.WriteLine("Enter Employ Number  ");
            //empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employ Name  ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department   ");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Designation  ");
            desig = Console.ReadLine();
            Console.WriteLine("Enter Basic   ");
            basic = Convert.ToInt32(Console.ReadLine());
            ObjectParameter param = new ObjectParameter("empno", typeof(int));
            entities.prcEmployInsert(param,name,"Male",dept,desig,basic);
            Console.WriteLine("*** Record Inserted ***");
            Console.WriteLine(param.Value);
        }
    }
}
