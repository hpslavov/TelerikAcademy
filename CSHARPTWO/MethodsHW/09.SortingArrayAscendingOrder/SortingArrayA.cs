using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArrayAscendingOrder
{
    //Write a method that return the maximal element in a portion of array of integers starting at given index.
    //Using it write another method that sorts an array in ascending order.
    class SortingArrayA
    {
        static int[] SortingArrayAscendingOrder(int[] array)
        {
            List<int> numbers = new List<int>(array);
            int buffer = int.MaxValue;
            int length = numbers.Count;
            numbers.Add(buffer);
            List<int> tempNumbers = new List<int>();
            for (int i = 0; i < length; i++)
            {
                tempNumbers.Add(numbers.Min());
                numbers.Remove(numbers.Min());
            }
            int[] sortedNumbers = tempNumbers.ToArray();

            return sortedNumbers;


        }
        static void Main()
        {
            int[] arrayOne = { 6, 9, 15, 11, 13, 0, 7, 2 };
            Console.WriteLine(string.Join(", ", SortingArrayAscendingOrder(arrayOne)));
        }
    }
}
