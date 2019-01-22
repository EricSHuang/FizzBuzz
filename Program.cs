using System;
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
            Console.WriteLine("Press 1 to play FizzBuzz. Press 2 to play Pamplemousse.");
            Console.Write("What game would you like to play: ");
            int game = int.Parse(Console.ReadLine());

            int startingNumber = 1;
            Console.Write("How many numbers of output would you like: ");
            double endingNumber = double.Parse(Console.ReadLine());
            if ((endingNumber <= 0) || (endingNumber > int.MaxValue))
            {
                Console.WriteLine("Sorry, that number is out of range. We outputted the first 20 numbers of FizzBuzz instead.");
                Console.WriteLine($"Please choose a number between 1 and {int.MaxValue} next time.");
                endingNumber = 20;
            }

            switch (game)
            {
                case 1:
                    int outputFizz = 3;
                    int outputBuzz = 5;
                    FizzBuzz(startingNumber, Convert.ToInt32(endingNumber), outputFizz, outputBuzz);
                    break;
                case 2:
                    int value = 4; //the number we want to check against.
                    string pamplemousse = "Pamplemousse";
                    Pamplemousse(startingNumber, Convert.ToInt32(endingNumber), value, pamplemousse);
                    break;
                default:
                    Console.WriteLine("That number is not one of the options.");
                    Console.WriteLine("Please press 1 to play FizzBuzz or press 2 to play Pamplemousse.");
                    //TODO: add loop so there can be reselection
                    break;
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
