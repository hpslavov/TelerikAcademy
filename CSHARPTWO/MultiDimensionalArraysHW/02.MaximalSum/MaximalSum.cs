using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal 
            //sum of its elements.
            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[rows, cols];

            int[,] matrix = {
                                {1,2,3,4,5,6,7,8},
                                {9,5,4,3,9,9,4,5},
                                {7,6,5,4,3,2,2,1}
                            };
            int maxPlat = int.MinValue;
            int maxRow = int.MinValue;
            int maxCol = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] +
                        matrix[row + 2,  col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxPlat)
                    {
                        maxPlat = sum;
                        maxRow = row;
                        maxCol = col;

                    }
                }
            }
            Console.WriteLine(("{0,3}{1,3}{2,3}"), matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol+2]);
            Console.WriteLine(("{0,3}{1,3}{2,3}"), matrix[maxRow+1, maxCol], matrix[maxRow+1, maxCol + 1], matrix[maxRow+2, maxCol+2]);
            Console.WriteLine(("{0,3}{1,3}{2,3}"), matrix[maxRow+2, maxCol], matrix[maxRow+2, maxCol + 1], matrix[maxRow+2, maxCol+2]);

        }
    }
}
