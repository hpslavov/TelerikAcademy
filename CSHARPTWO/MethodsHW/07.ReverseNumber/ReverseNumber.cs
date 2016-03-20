using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    //Write a method that reverses the digits of given decimal number.
    class ReverseNumber
    {
        static List<char> ReverseDigitsOfNumber(decimal number)
        {
            string numberFix = number.ToString();
            List<char> reversedNumber = new List<char>();
            for (int i = 0; i < numberFix.Length; i++)
            {
                reversedNumber.Add(numberFix[i]);
            }
            reversedNumber.Reverse();
            return reversedNumber;
        }
        static void Main()
        {
            Console.Write("Please enter number = ");
            decimal value = decimal.Parse(Console.ReadLine());

            Console.WriteLine(string.Join("",ReverseDigitsOfNumber(value)));
        }
    }
}
