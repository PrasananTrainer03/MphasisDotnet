using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDemo
{
    internal class Demo
    {
        public void Show(params string[] names)
        {
            foreach(string s in names)
            {
                Console.Write("Student Name  " +s);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.Show();
            obj.Show("Arka", "Naveen", "Prasad");
            obj.Show("Arka", "Naveen", "Prasad", "Kishore");
        }
    }
}
