﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace SerilizationExample
{
    internal class ReadEmploy
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"c:\files\employ.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binf = new BinaryFormatter();
            Employ employ = (Employ)binf.Deserialize(fs);
            Console.WriteLine(employ);
        }
    }
}
