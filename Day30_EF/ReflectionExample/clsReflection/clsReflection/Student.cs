using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsReflection
{
    public class Student
    {
        public string name;
        public double basic;
        public int empno;

        public int RollNo { get; set; }
        public string Name { get; set; }

        public Student()
        {
            RollNo = 0;
            Name = "Hello World";
        }

        public Student(int RollNo, string Name)
        {
            this.RollNo = RollNo;
            this.Name = Name;
        }

        public void ShowEmploy()
        {
            Console.WriteLine("From Employ Method...");
        }

        public void ReadEmploy()
        {
            Console.WriteLine("From ReadyEmploy Method...");
        }

        public override string ToString()
        {
            return "Roll No  " + RollNo + " Name " + Name;
        }

    }
}
