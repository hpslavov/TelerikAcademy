using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            //Write a program that creates an array containing all letters from the alphabet (A-Z).
            //Read a word from the console and print the index of each of its letters in the array.
            string word = Console.ReadLine().ToUpper();
            char[] alphaBet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphaBet.Length; j++)
                {
                    if (word[i]==alphaBet[j])
                    {
                        Console.WriteLine("[{0}] as index [{1}]",word[i],j);
                    }
                }
            }

        }
    }
}
