using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillMatrixC
{
    class FillMatrixC
    {
        static void Main()
        {
            //  7	11	14	16
            //  4	 8	12	15
            //  2	 5	 9	13
            //  1	 3	 6	10
            int rows = 4;//int.Parse(Console.ReadLine());
            int cols = 4;//int.Parse(Console.ReadLine());
            int[,] numbers = new int[rows, cols];
            int initial = 0;
            int startIndex = 1;
            int initialTwo = 0;
            int initialThree = 0;
            for (int i = numbers.GetLength(0)-1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows<numbers.GetLength(0) && cols < numbers.GetLength(1))
                {
                    numbers[rows++, cols++] = startIndex++;
                }
            }
            for (int j = 1; j < numbers.GetLength(0); j++)
            {
                rows = j;
                cols = 0;
                while (rows<numbers.GetLength(1) && cols < numbers.GetLength(0))
                {
                    numbers[cols++, rows++] = startIndex++;
                }
            }
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write("{0,3}",numbers[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
