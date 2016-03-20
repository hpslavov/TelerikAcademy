using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _04.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            //Write a program, that reads from the console an array of N integers and an integer K, sorts the array
            //and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

            //Console.Write("Enter size of array N = ");
            //int N = int.Parse(Console.ReadLine());
            int[] numbers = { 9, 14, 35, 7, 10 };
                                 
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Enter [{0}] = ",i);
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            Console.Write("Enter K = ");
            int K  = int.Parse(Console.ReadLine());
            int index = 0;
            int searchedNumber;
            Array.Sort(numbers);
            Console.WriteLine(string.Join(", ",numbers));
            Console.WriteLine(K);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<K)
                {
                    index = numbers[i];
                }
            }
            searchedNumber = Array.BinarySearch(numbers,index);
            if (numbers[0] > K)
            {
                Console.WriteLine("No number is lesser than the given max value.");
            }
            else
            {
                Console.WriteLine("Max number lesser than the given max value is: {0}", index);
            }
        }
    }
}
