using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketExample
{
    internal class Cricket
    {
        static int score;

        public void Incr(int x)
        {
            score += x;
        }
        static void Main(string[] args)
        {
            Cricket fb = new Cricket();
            Cricket sb = new Cricket();
            Cricket ext = new Cricket();

            fb.Incr(12);
            sb.Incr(84);
            ext.Incr(11);

            Console.WriteLine("Total Score is   " +Cricket.score);
        }
    }
}
