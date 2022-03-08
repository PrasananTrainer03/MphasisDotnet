﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileReadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\files\Program.cs", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = string.Empty;
            while((str=sr.ReadLine())!=null)
            {
                Console.WriteLine(str);
            }
            sr.Close();
            fs.Close();
        }
    }
}
