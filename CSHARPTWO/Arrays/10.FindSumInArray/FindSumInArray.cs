using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class FindSumInArray
    {
        static void Main()
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present)
            int[] numbers = { 4, 3, 1, 4, 2, 5, 8 };
            int S = 16;
            List<int> searchedSum = new List<int>();
            List<int> findSum = new List<int>();
            int sum = 0;
            bool isSum = false;
            while (isSum == false)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = i; j < numbers.Length; j++)
                    {
                        sum += numbers[j];
                        searchedSum.Add(numbers[j]);
                        if (sum == S)
                        {
                            isSum = true;
                            findSum.AddRange(searchedSum);
                            break;
                        }
                    }
                    sum = 0;
                    searchedSum.Clear();

                }
            }
            if (findSum.Count == 0)
            {
                Console.WriteLine("No sum S in array!");
            }
            if (sum != S)
            {
                Console.WriteLine("No sum found");
            }
            else
            {
                Console.WriteLine(string.Join(", ", findSum) + " |" + "Sum:" + S);
            }
        }
    }
}
