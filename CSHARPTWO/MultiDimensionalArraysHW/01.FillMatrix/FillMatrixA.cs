using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillMatrix
{
    class FillMatrixA
    {
        static void Main()
        {
            //Write a program that fills and prints a matrix of size (n, n) as shown below:
            //1	 5	9	13
            //2	 6	10	14
            //3	 7	11	15
            //4	 8	12	16
            int rows = 4;//int.Parse(Console.ReadLine());
            int cols = 4;//int.Parse(Console.ReadLine());
            int[,] numbers = new int[rows, cols];
            int startvalue = 1;
            int initial = 0;
            int initial2 = 0;
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {

                    numbers[row, col] = startvalue + initial + initial2;
                    initial += rows;
                }
                initial = 0;
                startvalue = 1;
                initial2++;
            }
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {


                    Console.Write("{0,3}", numbers[row, col]);


                }
                Console.WriteLine();
            }
        }
    }
}
