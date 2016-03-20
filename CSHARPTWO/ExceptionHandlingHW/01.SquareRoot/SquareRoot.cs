using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        //Write a program that reads an integer number and calculates and prints its square root.
        //If the number is invalid or negative, print Invalid number.
        //In all cases finally print Good bye.
        //Use try-catch-finally block.

        static double SquareR(double input)
        {
            if (input <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine(Math.Sqrt(input));
            return Math.Sqrt(input);
        }
        static void Main()
        {
            string input = Console.ReadLine();
            double inputOne = 0;
            try
            {
                inputOne = double.Parse(input);
                SquareR(inputOne);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
            }

            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
