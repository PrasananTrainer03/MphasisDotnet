﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleProg
{
    /// <summary>
    /// Program for Area and Circumference of Cirlce 
    /// </summary>
    internal class Demo
    {
        public void Calc(double radius)
        {
            double area, circ;
            area = 3.14 * radius * radius;
            circ = 2 * 3.14 * radius;
            Console.WriteLine("Area of Circle  " +area);
            Console.WriteLine("Circumference  " +circ);
        }
        static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Enter Radius    ");
            radius=Convert.ToDouble(Console.ReadLine());
            Demo obj = new Demo();
            obj.Calc(radius);
        }
    }
}
