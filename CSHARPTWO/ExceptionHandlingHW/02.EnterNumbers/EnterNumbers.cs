using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        //       Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
        //If an invalid number or non-number text is entered, the method should throw an exception.
        //Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

        static void ReadNumber(int start, int end)
        {
            Console.Write("Enter specified number = ");
            string number = Console.ReadLine();
            int numberInRange = 0;
            try
            {
                numberInRange = int.Parse(number);
            }
            catch (FormatException)
            {

                Console.WriteLine("Input number is not a digit!");
            }
            if (numberInRange > end || numberInRange < start)
            {
                throw new ArgumentOutOfRangeException("Input number is out of the [start..end] range!");
            }
            Console.WriteLine("No exception to handle!");

        }
        static void Main(string[] args)
        {
            Console.Write("Enter start of the range = ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end of the range = ");
            int end = int.Parse(Console.ReadLine());
            ReadNumber(start, end);

        }
    }
}
