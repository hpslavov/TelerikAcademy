using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            //Write a program that reads two integer numbers N and K and an array of N elements from the console.
            //Find in the array those K elements that have maximal sum.
            Console.WriteLine("Enter size of array:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K(numbers to find maximal sum):");
            int K = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            Console.WriteLine("Enter number in array:");
            for (int i = 0; i <numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int smallest = numbers[0];
            int biggest = numbers[0];
            Array.Sort(numbers);
            List<int> lists = numbers.ToList();
            List<int> sums = new List<int>();
            lists.Sort();   
            string sum = "";
            string listss = string.Join(", ",lists);
            for (int i = 0; i < K; i++)
            {
                sum += lists.Max() + " ";
                sums.Add(lists.Max());
                lists.Remove(lists.Max());
                
            }
            string join = string.Join(", ",sum);
            Console.WriteLine(join);
        }
    }
}
