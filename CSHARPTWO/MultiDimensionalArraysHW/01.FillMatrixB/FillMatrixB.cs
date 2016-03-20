using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillMatrixB
{
    class FillMatrixB
    {
        static void Main(string[] args)
        {
            //Write a program that fill and print the matrix below.
            //1	 8	9	16
            //2	 7	10	15
            //3	 6	11	14
            //4	 5	12	13
            int rows = 4;//int.Parse(Console.ReadLine());
            int cols = 4;//int.Parse(Console.ReadLine());
            int[,] numbers = new int[rows, cols];
            int initial = 0;
            int startIndex = 1;
            int initialTwo = 0;
            int initialThree = 0;
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = startIndex + initial + initialTwo;
                    initial += rows;
                }
                initial = 0;
                startIndex = 1;
                initialTwo++;
            }



            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    if (col % 2 != 0)
                    {
                        Console.Write("{0,3}", numbers[numbers.GetLength(1) - 1 - row, col]);
                    }
                    else
                    {
                        Console.Write("{0,3}", numbers[row, col]);

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
