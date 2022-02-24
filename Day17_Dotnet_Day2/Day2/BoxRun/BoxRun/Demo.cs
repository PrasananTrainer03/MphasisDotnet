using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxRun
{
    internal class Demo
    {
        public void Show(object ob)
        {
          //  Console.WriteLine(ob.GetType());
            string type = ob.GetType().Name;
            Console.WriteLine(type);
            if (type.Equals("Int32"))
            {
                Console.WriteLine("Integer Casting...");
                int x = (Int32)ob;
            }
            if (type.Equals("Double"))
            {
                Console.WriteLine("Double Casting...");
                double x = (Double)ob;
            }
            if (type.Equals("String"))
            {
                Console.WriteLine("String Casting...");
                string x = (String)ob;
            }
        }
        static void Main(string[] args)
        {
            int a = 12;
            double b = 12.5;
            string name = "Prasanna";
            Demo obj = new Demo();
            obj.Show(a);
            obj.Show(b);
            obj.Show(name);
        }
    }
}
