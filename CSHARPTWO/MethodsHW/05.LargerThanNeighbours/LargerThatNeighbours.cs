using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargerThanNeighbours
{
    class LargerThatNeighbours
    {
        static bool FindElementLargerThanNeighbours(int[] array, int numberPosition)
        {
            bool isLarger = false;
            if (Array.IndexOf(array, array[numberPosition]) == Array.IndexOf(array, array[array.Length - 1]))
            {
                if (array[numberPosition] > array[array.Length - 2])
                {
                    isLarger = true;
                }
                else
                {
                    isLarger = false;
                }
            }
            else if (Array.IndexOf(array, array[numberPosition]) == Array.IndexOf(array, array[0]))
            {
                if (array[0] > array[1])
                {
                    isLarger = true;
                }
                else
                {
                    isLarger = false;
                }
            }
            else if (array[numberPosition] > array[numberPosition - 1] && array[numberPosition] > array[numberPosition + 1])
            {
                isLarger = true;
            }
            else
            {
                isLarger = false;
            }
            return isLarger;
        }
        static void Main()
        {
            //Write a method that checks if the element at given position in given array of integers is larger 
            //than its two neighbours (when such exist).
            int[] numbers = { 7, 4, 9, -2, -1, -6, 2, 5, -9, -5, 10, 16, 3 };
            Console.Write("Please enter Element to check: ");
            int element = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(numbers, element);
            bool result = FindElementLargerThanNeighbours(numbers, index);
            Console.WriteLine(result);
        }
    }
}
