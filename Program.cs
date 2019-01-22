using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************
 * Project Name: FizzBuzz
 * By: Eric Huang
 * Date: 2019 Jan. 22nd
 * 
 * Plays the game FizzBuzz and an alternate version of FizzBuzz called Pamplemousse.
 * FizzBuzz counts up numbers starting from 1. When the number is divisible by 3, say Fizz. When the number is divisble by 5, say Buzz.
 * When the number is divisble by both 3 and 5, say FizzBuzz.
 * 
 * Pamplemousse works like FizzBuzz. Count up starting from 1.
 * When the number is divisible by 4 or contains 4, say Pamplemousse. 
 * For example, you say 1, 2, 3 for those respective numbers, but say Pamplemousse for the numbers 4, 8, or 14.
 *************/

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to play FizzBuzz. Press 2 to play Pamplemousse.");
            Console.Write("What game would you like to play: ");
            int game = int.Parse(Console.ReadLine());

            int startingNumber = 1;
            Console.Write("How many numbers of output would you like: ");
            double endingNumber = double.Parse(Console.ReadLine());
            if ((endingNumber <= 0) || (endingNumber > int.MaxValue))
            {
                Console.WriteLine("Sorry, that number is out of range. We outputted the first 20 numbers instead.");
                Console.WriteLine($"Please choose a number between 1 and {int.MaxValue} next time.");
                endingNumber = 20;
            }

            bool gameNotComplete = true;
            while (gameNotComplete)
            {
                switch (game)
                {
                    case 1:
                        int outputFizz = 3;
                        int outputBuzz = 5;
                        FizzBuzz(startingNumber, Convert.ToInt32(endingNumber), outputFizz, outputBuzz);
                        gameNotComplete = false;
                        break;
                    case 2:
                        int value = 4; //if the number is divisible by or contains "value", output pamplemousse
                        string pamplemousse = "Pamplemousse";
                        Pamplemousse(startingNumber, Convert.ToInt32(endingNumber), value, pamplemousse);
                        gameNotComplete = false;
                        break;
                    default:
                        Console.WriteLine("That number is not one of the options.");
                        Console.Write("Please press 1 to play FizzBuzz or press 2 to play Pamplemousse: ");
                        game = int.Parse(Console.ReadLine());
                        break;
                }
            }
            
            //Used to keep the console on screen and text readable
            Console.ReadLine();
        }


        static void FizzBuzz(int start, int end, int outputFizz, int outputBuzz)
        {
            for (int i = start; i <= end; i++)
            {
                if ((i % outputFizz == 0) && (i % outputBuzz == 0))
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
        }

        static void Pamplemousse(int start, int end, int value, string pamplemousse)
        {
            string valueString = value.ToString();
            for(int i = start; i <= end; i++)
            {
                string intString = i.ToString();
                if ((intString.Contains(valueString)) || (i % value == 0)){
                    Console.WriteLine(pamplemousse);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
