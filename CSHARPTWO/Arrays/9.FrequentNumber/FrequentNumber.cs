using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            //Write a program that finds the most frequent number in an array.
            int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int tempCounter = 1;
            int counter = 0;
            int frequentCounter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != frequentCounter)
                {
                    for (int j = i+1; j < numbers.Length-1; j++)
                    {
                        if (numbers[j]==numbers[i])
                        {
                            tempCounter++;
                        }

                    }
                    if (tempCounter > counter)
                    {
                        counter = tempCounter;
                        frequentCounter = numbers[i];
                    }
                    tempCounter = 1;
                }

            }
            Console.WriteLine("{0}, {1} times",frequentCounter,counter);
        }
    }
}
