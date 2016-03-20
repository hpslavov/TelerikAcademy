using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CompareArrays2
{
    class CompareArrays2
    {
        static void Main()
        {
            Console.Write("Enter first array size = ");
            int sizeOne = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[sizeOne];
            Console.Write("Enter second array size = ");
            int sizeTwo = int.Parse(Console.ReadLine());
            int[] arrayTwo = new int[sizeTwo];
            if (arrayOne.Length != arrayTwo.Length)
            {
                Console.WriteLine("ArrayOne is not equal to ArrayTwo");
            }
            Console.WriteLine("Enter {0} elements of ArrayOne each on separate line ", sizeOne);
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter {0} elements of ArrayTwo each on a separate line ", sizeTwo);
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }

            if (arrayOne.Length == arrayTwo.Length)
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                    {
                        Console.WriteLine("ArrayOne is equal to ArrayTwo");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ArrayOne is not equal to ArrayTwo");
                        break;
                    }
                }
            }

        }
    }
}
