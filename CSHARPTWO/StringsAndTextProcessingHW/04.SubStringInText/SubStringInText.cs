using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SubStringInText
{
    class SubStringInText
    {
        static int CountSubStringInString(string text,string substring)
        {
            int count = 0;
            int i = 0;
            while ((i=text.IndexOf(substring,i)) != -1)
            {
                i += substring.Length;
                count++;
            }
            return count;
        }
        //Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
        static void Main()
        {
            string input = Console.ReadLine();
            string substring = "in";
            input.ToLower();
            Console.WriteLine(CountSubStringInString(input,substring));
        }
    }
}
