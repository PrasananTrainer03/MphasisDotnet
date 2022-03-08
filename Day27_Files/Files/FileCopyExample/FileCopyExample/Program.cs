using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileCopyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream src = new FileStream(@"c:\files\Program.cs", FileMode.Open, FileAccess.Read);
            FileStream tar = new FileStream(@"c:\files\Targete.cs", FileMode.Create, FileAccess.Write);

            StreamReader sr = new StreamReader(src);
            StreamWriter sw = new StreamWriter(tar);

            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            string str = string.Empty;
            while((str=sr.ReadLine())!=null)
            {
                sw.WriteLine(str);
            }
            sr.Close();
            sw.Close();
            Console.WriteLine("*** File Copied ***");
        }
    }
}
