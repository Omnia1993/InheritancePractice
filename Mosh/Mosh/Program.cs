﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace Mosh
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Enter number :");
            
           /*int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 1 && x <= 10)
            {
           //     Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("invalid");*/
        //Console.WriteLine("Enter the first number");
       // int num1 = Convert.ToInt32(Console.ReadLine());
         //   Console.WriteLine("Enter the second number");
       Console.ReadLine();
            int high = Utils.GetNumber("Enter High");
            int width = Utils.GetNumber("Enter width");
            if (high>width)
            {
                Console.WriteLine("its portrait");
            }
            else
                Console.WriteLine("its landscape");
          //  Console.WriteLine(Math.Max(num1,num2) + "  is biggest one");

        }


    }
}
