using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLetters
{
    class SeriesOfLetters
    {
        //Write a program that reads a string from the console
        //and replaces all series of consecutive identical letters with a single one.
        //Example: aaaaabbbbbcdddeeeedssaa
        //output: abcdedsa
        static List<char> ExtractLetters(string input)
        {
            input = input.ToLower();
            List<char> result = new List<char>();
            result.Add(input[0]);
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i+1] != input[i])
                {
                    char temp = input[i + 1];
                    result.Add(temp);
                }
            }
            Console.WriteLine(string.Join("",result));
            return result;
        }
        static void Main()
        {
            string input = "aaaaabbbbbcdddeeeedssaa";
            ExtractLetters(input);
        }
    }
}
