using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        public static int BinarySearching(int[] numbers,int startValue,int endValue,int keyValue)
        {
            int midValue;
            while (startValue<=endValue)
            {
                midValue = (startValue + endValue) / 2;
                if (numbers[midValue]<keyValue)
                {
                    startValue = midValue + 1;
                    continue;
                }
                else if (numbers[midValue]>keyValue)
                {
                    startValue = midValue - 1;
                    continue;
                }
                else
                {
                    return midValue;
                }
            }
            return -1;
        }
        static void Main()
        {
            //Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm
            //Console.Write("Enter size of array N = ");
            int N = 10;//int.Parse(Console.ReadLine());
            int[] array = { 1, 5, 3, 72, 46, 91, 83, 22, 66, 0};//new int[N];
            int key = 3;//int.Parse(Console.ReadLine());
            int ind = int.MinValue;
            int start = array[0];
            int end  = array[array.Length - 1];
            Array.Sort(array);
            BinarySearching(array, start, end, key);
            Console.WriteLine(Array.IndexOf(array,key));
        }
    }
}
