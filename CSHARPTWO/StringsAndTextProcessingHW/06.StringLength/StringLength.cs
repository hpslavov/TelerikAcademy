using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringLength
{
    class StringLength
    {
        static void Main()
        {
            //Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
            //Print the result string into the console.
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                Console.WriteLine("Enter string length = 20 characters");
            }
            Console.WriteLine(input.PadRight(20,'*'));
        }
    }
}
