using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SelectionSort
{
    class SelectionSort
    {
        static void Swap(ref int y,ref int x)
        {
            int temp = y;
            y = x;
            x = temp;

        }
        static void Main(string[] args)
        {
            //Find the smallest element, move it at the first position, find the smallest from the 
            //rest, move it at the second position, etc.
            Console.Write("Enter array length : ");
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int minimalIndex;
            int tempMin;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                minimalIndex = i;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j]<numbers[minimalIndex])
                    {
                        minimalIndex = j;
                    }
                }
                if (minimalIndex!= i)
                {
                    Swap(ref numbers[minimalIndex],ref numbers[i]);
                }
            }
            Console.WriteLine(string.Join(", ",numbers));
        }

    }
}

