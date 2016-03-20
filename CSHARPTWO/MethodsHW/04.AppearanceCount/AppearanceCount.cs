using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        static int AppearanceInArray(int[] array,int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main()
        {
            //Write a method that counts how many times given number appears in given array.
            //Write a test program to check if the method is workings correctly.
            int[] numbers = { 1, 2, 3, 3, 4, 5, 8, 17, 4, 4, 4, };
            Console.Write("Enter number = ");
            int K = int.Parse(Console.ReadLine());
            int temporary = AppearanceInArray(numbers,K);
            Console.WriteLine("{0} times in array",temporary);

        }
    }
}
