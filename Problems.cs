﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems_A
{
    public class Problems
    {
        public void UseCaseProblem()
        { 
            int a, b, c;
            Console.Write("1st number :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2nd number :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("3rd number :");
            c = Convert.ToInt32(Console.ReadLine());
            // value comparison using nested if condition
            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("The 1st Number is the greatest.\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest.\n");
                }
            }
            else if (b > c)
            {
                Console.Write("The 2nd Number is the greatest.\n");
            }
            else
            {
                Console.Write("The 3rd Number is the greatest.\n");
            }
        }
    }
}

