using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Palindromes
{
    class Palindrome
    {
        //Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }

        }
        static List<string> CountPalindromes(string input)
        {
            List<string> paliList = new List<string>();
            paliList = input.Split(' ').ToList<string>();
            List<string> result = new List<string>();
            foreach (string word in paliList)
            {
                bool tempPali = IsPalindrome(word);
                if (tempPali==true)
                {
                    result.Add(word);
                }
            }
            Console.WriteLine(string.Join(" ",result));
            return paliList;
        }
        static void Main()
        {
            string input = "ABBA Are you listening to ABBA to match the EXE  lal WOW  BAAB conditions";
            CountPalindromes(input);
        }
    }
}
