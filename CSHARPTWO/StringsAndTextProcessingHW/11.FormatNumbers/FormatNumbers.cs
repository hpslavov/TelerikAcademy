using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FormatNumbers
{
    class FormatNumbers
    {
        //Write a program that reads a number and prints it as a decimal number,
        //hexadecimal number, percentage and in scientific notation.
        //Format the output aligned right in 15 symbols.
        static void Main()
        {
            Console.Write("Enter number: ");
            long input = long.Parse(Console.ReadLine());
            string result = string.Format("");
            Console.WriteLine("{0,15:,0.00}",input);
            Console.WriteLine("{0,15:X}", input);
            Console.WriteLine("{0,15:#.%}",input);
            Console.WriteLine("{0,15:E}",input);
        }
    }
}
