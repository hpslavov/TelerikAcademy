using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        //Write a program that converts a string to a sequence of C# Unicode character literals.
        //H i ! :	\u0048\u0069\u0021
        static string CharacterFormatter(string input)
        {
            char[] array = input.ToCharArray();
            string result = string.Empty;
            
            foreach (char item in array)
            {
                int temp = item;
                result += string.Format("{0}{1}{2}",@"\u","00",temp.ToString("X"));
            }
            Console.WriteLine(result);
            return result;

        }
        static void Main()
        {
            string input = "Zero!";
            CharacterFormatter(input);

        }
    }
}
