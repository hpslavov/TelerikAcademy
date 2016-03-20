using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.WordDictionary
{
    class WordsInDictionary
    {
        //A dictionary is stored as a sequence of text lines containing words and their explanations.
        //Write a program that enters a word and translates it by using the dictionary.
        //.NET	platform for applications from Microsoft
        //CLR	managed execution environment for .NET
        //namespace	hierarchical organization of classes
        static void Dictionary(string word)
        {
            word = word.ToLower();
            switch (word)
            {
                case ".net": Console.WriteLine(".NET - platform for applications from Microsoft"); break;
                case "clr": Console.WriteLine("CLR - managed execution environment for .NET"); break;
                case "namespace": Console.WriteLine("namespace - hierarchical organization of classes"); ; break;
                default: Console.WriteLine("No word in dictionary - process another!");
                    break;
            }
        }
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary(input);

        }
    }
}
