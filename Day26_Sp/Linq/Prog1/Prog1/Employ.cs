using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    public class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }

        public string Desig { get; set; }
        public double Basic { get; set; }

        public override string ToString()
        {
            return "Employ No  " + Empno + " Employ Name  " + Name + " Department  " + Dept + " Designation  "
                    + Desig + " Basic  " + Basic;
        }
    }
}
