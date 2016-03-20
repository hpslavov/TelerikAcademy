using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    //Write a method that return the maximal element in a portion of array of integers starting at given index.
    //Using it write another method that sorts an array in ascending / descending order.
    class SortingArray
    {
        static int FindMaximalElementInRange(int[] array, int index)
        {
            List<int> numbers = new List<int>();
            for (int i = index; i < array.Length - 1; i++)
            {
                numbers.Add(array[i]);
            }
            int newValue = numbers.Max();
            return newValue;

        }
        static void Main()
        {
            int[] arrayOne = { 1, 5, 6, 10, 15, 71, 1, 4, 2 };
            Console.Write("Enter index: ");
            int indexer = int.Parse(Console.ReadLine());
            int result = FindMaximalElementInRange(arrayOne,indexer);
            Console.WriteLine("Maximal element in range index[{0}] - index[{1}] is |{2}|",indexer,arrayOne.Length-1,result);
        }
    }
}
