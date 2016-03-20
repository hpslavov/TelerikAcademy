using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.OrderWords
{
    class OrderWords
    {
        //Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
        static List<string> WordSorter(string list)
        {
            List<string> words = new List<string>();
            words = list.Split(' ').ToList<string>();
            words.Sort();
            Console.WriteLine(string.Join(" ",words));
            return words;
        }
        static void Main()
        {
            string input = Console.ReadLine();
            WordSorter(input);
        }
    }
}
