using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        //Write a program to check if in a given expression the brackets are put correctly.
        static void Main()
        {
            string input = Console.ReadLine();
            int leftBracket = 0;
            int rightBracket = 0;
            char left = '(';
            char right = ')';
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == left)
                {
                    leftBracket++;
                }
                else if (input[i] == right)
                {
                    leftBracket--;
                }
            }
            if (leftBracket==0)
            {
                Console.WriteLine("Correct");

            }
            else
            {
                Console.WriteLine("Incorrrect string");

            }
        }
    }
}
