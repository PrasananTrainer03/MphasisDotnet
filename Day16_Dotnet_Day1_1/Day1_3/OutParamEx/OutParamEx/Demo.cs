using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParamEx
{
    internal class Demo
    {
        public void Show(int empno, out string name, out double basic)
        {
            if (empno==1)
            {
                name = "Lamiya";
                basic = 92345;
            } else if (empno==2)
            {
                name = "Sandhya";
                basic = 92144;
            } else if (empno==3)
            {
                name = "Sindhu";
                basic = 94224;
            } else
            {
                name = "Not Found";
                basic = 0;
            }
        }
        static void Main(string[] args)
        {
            int empno;
            Console.WriteLine("Enter Employ No    ");
            empno = Convert.ToInt32(Console.ReadLine());
            Demo obj = new Demo();
            obj.Show(empno, out string name, out double basic);
            Console.WriteLine("Name is  " +name);
            Console.WriteLine("Salary is  " +basic);
        }
    }
}
