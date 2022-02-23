using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoToString
{
    public class Student
    {
        public int sno;
        public string name;
        public double cgp;
        public string city;

        public override string ToString()
        {
            return "Student No " + sno + " Student Name " + name + " Cgp  " + cgp + " City " + city;
        }
    }
}
