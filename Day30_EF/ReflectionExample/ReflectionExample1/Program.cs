using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clsReflection;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type objStudent = typeof(Student);

            Console.WriteLine("Fields available in the current class are ");
            foreach(FieldInfo f in objStudent.GetFields())
            {
                Console.WriteLine(f.Name);
            }

            Console.WriteLine("Methods Avaialbe in the current class are  ");
            foreach(MethodInfo m in objStudent.GetMethods())
            {
                Console.WriteLine(m.Name);
            }

            Console.WriteLine("Constructors are  ");
            foreach(ConstructorInfo c in objStudent.GetConstructors())
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}
