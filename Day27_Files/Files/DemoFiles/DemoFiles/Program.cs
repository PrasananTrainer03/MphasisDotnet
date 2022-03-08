using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DemoFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\files\demo.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Welcome to Files...");
            sw.WriteLine("From Mphasis Batch...");
            sw.Close();
            fs.Close();
            Console.WriteLine("File Created Successfully...");
        }
    }
}
