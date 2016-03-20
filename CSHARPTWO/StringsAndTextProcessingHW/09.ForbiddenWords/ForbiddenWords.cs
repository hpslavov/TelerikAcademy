using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        //We are given a string containing a list of forbidden words and a text containing some of these words.
        //Write a program that replaces the forbidden words with asterisks.
        //Example text: Microsoft announced its next generation PHP compiler today.
        //It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
        //Forbidden words: PHP, CLR, Microsoft
        //
        static string[] WordReplacer(string input)
        {
            
            string[] temp = input.Split();
            List<string> result = new List<string>();
            //foreach (string str in temp)
            //{
            //    string temporary = str;
            //    result.Add(temporary);
            //}
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == "PHP" || temp[i] == "CLR" || temp[i] == "Microsoft")
                {
                    string temporal = new string('*',temp[i].Length);
                    temp[i] = temporal;
                }
            }

            Console.WriteLine(string.Join(" ",temp));
            return temp;
        }
        static void Main()
        {
            string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR .";
            List<string> forbiddenWords = new List<string> { "PHP", "CLR", "Microsoft" };
            WordReplacer(input);
        }
    }

}