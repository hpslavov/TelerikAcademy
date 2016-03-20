using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    public class LongestString
    {
        static void Main()
        {
            //task 17
            //Write a program to return the string with maximum length from an array of strings.
            //use LINQ;

            string[] strings = { "abc", "america", "baana", "tulip" };

            string longestString = strings.OrderByDescending(s => s.Length).First();


            Console.WriteLine(longestString);
        }
    }
}
