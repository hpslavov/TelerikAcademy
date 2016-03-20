using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LettersCount
{
    class LetterCounter
    {
        //Write a program that reads a string from the console and prints all different letters in 
        //the string along with information how many times each letter is found.
        static List<char> LetterCount(string input)
        {
            List<char> letterList = new List<char>();
            letterList = input.ToList<char>();
            List<string> letterOccurence = new List<string>();
            string temp = string.Empty;
            int counter = 0;
            foreach (char letters in letterList)
            {
                var matchLetters = from letterD in letterList where letterD == letters select letterD;
                int letterCount = matchLetters.Count();
                temp = letterList[counter] + " " + letterCount;
                letterOccurence.Add(temp);
                counter++;
            }
            letterOccurence = letterOccurence.Distinct().ToList<string>();
            Console.WriteLine(string.Join("\n",letterOccurence));
            return letterList;
        }
        static void Main()
        {
            string input = "aaabbcddeeefdfgghhkkkiii";
            LetterCount(input);
        }
    }
}
