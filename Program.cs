﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int startingNumber = 1;
            int endingNumber = 20;
            int outputFizz = 3;
            int outputBuzz = 5;
 
            for(int i = startingNumber; i <= endingNumber; i++)
            {
                if (i % outputFizz == 0 && i % outputBuzz == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % outputFizz == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % outputBuzz == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            //Used to keep the console on screen and text readable
            Console.ReadLine();
        }
    }
}