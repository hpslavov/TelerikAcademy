using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
            //Print the obtained array on the console.

            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Console.WriteLine("Allocated Array:");
            foreach (var item in array)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
            Console.WriteLine("Multiplied array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * 5;
            }
            foreach (var item in array)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();

        }
    }
}
