using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            //Write a program that finds the maximal increasing sequence in an array.
            int[] arraOne = { 1, 2, 3, 4, 2, 2, 4 };
            int tempCount = 1;
            string tempSequence = "";
            int maxCount = 1;
            string maxSequence = "";
            for (int i = 0; i < arraOne.Length - 1; i++)
            {
                if (arraOne[i] < arraOne[i + 1])
                {
                    tempCount++;
                    tempSequence += arraOne[i] + " ";
                }
                else
                {
                    if (tempCount > maxCount)
                    {
                        maxCount = tempCount;
                        tempSequence += arraOne[i] + " ";
                        maxSequence = tempSequence;
                    }
                    tempCount = 1;
                    tempSequence = "";
                }
            }
            if (tempCount > maxCount)
            {
                tempSequence += arraOne[arraOne.Length - 1];
                maxSequence = tempSequence;
            }
            Console.WriteLine(maxSequence);
        }

    }
}
