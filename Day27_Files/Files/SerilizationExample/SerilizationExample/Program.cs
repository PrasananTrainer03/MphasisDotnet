using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace SerilizationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ employ = new Employ();
            employ.Empno = 1;
            employ.Name = "Yashwanth";
            employ.Basic = 99234;

            FileStream fs = new FileStream(@"c:\files\employ.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter binf = new BinaryFormatter();
            binf.Serialize(fs, employ);
            Console.WriteLine("Employ Object Stored in File...");
            fs.Close();
        }
    }
}
