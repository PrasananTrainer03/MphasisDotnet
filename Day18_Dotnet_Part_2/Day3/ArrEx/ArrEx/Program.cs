using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[]{ 12,5};
            try
            {
                a[10] = 92;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Array size is small...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
