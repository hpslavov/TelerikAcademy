using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        //Write a program that generates and prints to the console 10 random values in the range [100, 200].
        static void Main()
        {
            List<int> valuesList = new List<int>();
            Random generator = new Random();
            int temp = 0;
            for (int i = 0; i <= 10; i++)
            {
                temp = generator.Next(100, 200);
                valuesList.Add(temp);
            }
            Console.WriteLine("Random values:\n{0}",string.Join(", ",valuesList));
        }
    }
}
