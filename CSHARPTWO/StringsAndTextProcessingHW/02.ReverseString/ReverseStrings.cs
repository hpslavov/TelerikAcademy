using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class ReverseStrings
    {
        //Write a program that reads a string, reverses it and prints the result at the console
        static void Main()
        {
            Console.Write("enter string = ");
            string input = Console.ReadLine();
            List<char> reverse = new List<char>();
            char temp;
            for (int i = 0; i < input.Length; i++)
            {
                temp = input[i];
                reverse.Add(temp);
            }
           reverse.Reverse();
            Console.WriteLine(string.Join("", reverse));
        }
    }
}
