using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortByStringLength
{
    class SortByStringLength
    {
        static void Main()
        {
            //You are given an array of strings. 
            //Write a method that sorts the array by the length of its elements (the number of characters composing them).
            Console.Write("Enter array size = ");
            int n = int.Parse(Console.ReadLine());
            string[] arrayStrings = new string[n];
            for (int i = 0; i < arrayStrings.Length; i++)
            {
                Console.Write("[{0}] = ",i);
                arrayStrings[i] = Console.ReadLine();
            }
            Array.Sort(arrayStrings, (t, l) => t.Length.CompareTo(l.Length));
            foreach (string item in arrayStrings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
