using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsCount
{
    class Program
    {
        //Write a program that reads a string from the console and lists 
        //all different words in the string along with information how many times each word is found.
        static List<string> WordCounter(string input)
        {
            List<string> words = new List<string>();
            int counter = 0;
            words = input.Split(' ').ToList<string>();
            List<string> wordOccurence = new List<string>();
            string addingWord = string.Empty;
            foreach (string str in words)
            {
                var matchWords = from word in words where word.ToLowerInvariant() == str.ToLowerInvariant() select word;
                int wordCount = matchWords.Count();
               addingWord = words[counter] + " " + wordCount;
               wordOccurence.Add(addingWord);
                counter++;
            }
           wordOccurence = wordOccurence.Distinct().ToList<string>();
            Console.WriteLine(string.Join("\n",wordOccurence));
            return words;
        }
        static void Main()
        {
            string input = "america bolivia bulgaria america hungary hungary america bolivia bulgaria stonehange";
            WordCounter(input);
        }
    }
}
