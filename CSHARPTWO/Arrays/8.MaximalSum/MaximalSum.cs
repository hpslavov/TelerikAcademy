using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            //Write a program that finds the sequence of maximal sum in given array.
            // 2, 3, -6, -1, 2, -1, 6, 4, -8, 8
            int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int sum = 0;
            int maxSum = 0;
            List<int> sequence = new List<int>();
            List<int> maximumSequence = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                    sequence.Add(numbers[j]);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maximumSequence.Clear();
                        maximumSequence.AddRange(sequence);
                    }
                }
                sum = 0;
                sequence.Clear();
            }
            Console.WriteLine(string.Join(", ",maximumSequence));
        }
    }
}
