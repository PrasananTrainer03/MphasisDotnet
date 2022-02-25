﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    public class Demo
    {
        public void Check(int age)
        {
            if (age < 18)
            {
                throw new VotingException("You are not elligible for voting...");
            } else
            {
                Console.WriteLine("You are elligible for voting...");
            }
        }
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter Age    ");
            age = Convert.ToInt32(Console.ReadLine());
            Demo obj = new Demo();
            try
            {
                obj.Check(age);
            }
            catch(VotingException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
