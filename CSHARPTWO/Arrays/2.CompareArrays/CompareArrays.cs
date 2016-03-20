using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            //Write a program that reads two integer arrays from the console and compares them element by element.
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];
            Console.WriteLine("Enter 5 numbers of firstarray:");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter 5 numbers of secondarray:");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            bool isEqual = false;
            if (firstArray.SequenceEqual(secondArray))
            {
                Console.WriteLine("Arrays are equal");
            }
            else
            {
                Console.WriteLine("Arrays not equal");
            }
        }
    }
}
