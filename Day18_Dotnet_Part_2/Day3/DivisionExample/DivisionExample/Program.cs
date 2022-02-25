﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 2 Numbers  ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Division is  " + c);
            }
            catch (FormatException e)
            {
                Console.WriteLine("String Cannot be Converted as Integer...");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Number is Too Big...");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero impossible...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Program from Mphasis Brnach...");
            }
        }
    }
}
