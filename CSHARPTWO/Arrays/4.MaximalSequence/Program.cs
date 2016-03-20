using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MaximalSequence
{
    class Program
    {
        static void Main()
        {
            //Write a program that finds the maximal sequence in an array.

            int[] input = { 1, 2, 3, 4, 2, 2, 22, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 2, 1 };
            int maxCount = 0;
            int tempCount = 0;  
            int value = 0;
            for (int i = 0; i < input.Length; i++)
            {
                tempCount = 1;
                for (int j = i + 1; j < input.Length - 1; j++)
                {

                    if (input[i] == input[j])
                    {
                        tempCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                    value = input[i];
                }

            }
            int[] output = new int[maxCount];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = value;
            }
            string stringOutput = string.Join(", ", output);
            Console.WriteLine(stringOutput);
        }
    }
}
