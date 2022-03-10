using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using clsReflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample1
{
    internal class NewProg
    {
        static void Main()
        {
            Type typeObj = typeof(Student);

            Assembly exec = Assembly.GetAssembly(typeObj);

            Type[] types = exec.GetTypes();

            foreach (var v in types)
            {
                Console.WriteLine("Class Name  " + v.Name);

                MethodInfo[] methods = v.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method
                    Console.WriteLine("--> Method : {0}", method.Name);


                    // Array to store parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }


        }
    }
}
