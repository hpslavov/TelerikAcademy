//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
namespace _06.DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DivisibleNumbers
    {
        static void Main()
        {
            var numbers = new int[] { 441, 33, 2, -2, 6, 8, 19, 5, 21, 18, 35, 70, 9261, 3 };

            //with LINQ
            var result =
                from num in numbers
                where (num % 7 == 0) && (num % 3 == 0)
                select num;

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //with built-in extension methods
            var secondResult = numbers.Where(x => (x % 7 == 0) && (x % 3 == 0));

            foreach (var num in secondResult)
            {
                Console.WriteLine(num);
            }

        }
    }
}
