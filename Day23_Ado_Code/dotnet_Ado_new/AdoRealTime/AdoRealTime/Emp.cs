using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoRealTime
{
    public class Emp
    {
        public int Empno { get; set; }
        public string Nam { get; set; }
        public string Dept { get; set; }
        public string Desig { get; set; }
        public int Basic { get; set; }

        public override string ToString()
        {
            return "Employ No " + Empno + " Employ Name  " + Nam + " Department  "
                + Dept + " Designation  " + Desig + " Basic  " + Basic;
        }
    }
}
