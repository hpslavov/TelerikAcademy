using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            //Write a program that compares two char arrays lexicographically (letter by letter).
            char[] arrayOne = Console.ReadLine().ToArray();
            int lengthOne = arrayOne.Length;
            char[] arrayTwo = Console.ReadLine().ToArray();
            int lengthTwo = arrayTwo.Length;
            int length = Math.Min(lengthOne, lengthTwo);
            int index = 0;
            bool isEqual = true;
            if (lengthOne >lengthTwo)
            {
                Console.WriteLine("2 array is earlier");
            }
            if (lengthOne<lengthTwo)
            {
                Console.WriteLine("1 array is earlier");
            }
            else if (lengthOne==lengthTwo)
            {
                for (int i = 0; i < length; i++)
                {

                    if (arrayOne[i]<arrayTwo[i])
                    {
                        index = 1;
                        break;
                    }
                    else if (arrayTwo[i]<arrayOne[i])
                    {
                        index = 2;
                        break;
                    }
                }
                if (index==0)
                {
                    Console.WriteLine("Arrays are equal");
                }
                else
                {
                    Console.WriteLine("{0} array is earlier",index);
                }
            }




        }
    }
}
