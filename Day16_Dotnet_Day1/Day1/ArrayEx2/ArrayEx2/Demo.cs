using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx2
{
    internal class Demo
    {
        public void Show()
        {
            string[] names = new string[]
            {
                "Rashmi","Revti","Jhansi","Rohan","Sanket"
            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.Show();
        }
    }
}
