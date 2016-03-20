using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArrayDescendingOrder
{
    ////Write a method that return the maximal element in a portion of array of integers starting at given index.
    //Using it write another method that sorts an array in descending order.
    class SortingArrayD
    {
        static int[] SortingArrayAscendingOrder(int[] array)
        {
            List<int> numbers = new List<int>(array);
            int buffer = int.MinValue;
            int length = numbers.Count;
            numbers.Add(buffer);
            List<int> tempNumbers = new List<int>();
            for (int i = 0; i < length; i++)
            {
                tempNumbers.Add(numbers.Max());
                numbers.Remove(numbers.Max());
            }
            int[] sortedNumbers = tempNumbers.ToArray();

            return sortedNumbers;


        }
        static void Main()
        {
            int[] arrayOne = { 116, 1119, 15, 11, 0, 1113, 110, 7, 2 };
            Console.WriteLine(string.Join(", ", SortingArrayAscendingOrder(arrayOne)));
        }
    }
}
