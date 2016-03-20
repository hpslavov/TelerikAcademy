using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumIntegers
{
    class SumIntegers
    {
        //You are given a sequence of positive integer values written into a string, separated by spaces.
        //Write a function that reads these values from given string and calculates their sum.
        static double SumSequenceOfIntegers(string input)
        {
            string[] inputList = new string[input.Length];
            inputList = input.Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries);
            double temp = 0;
            List<double> doubleValue = new List<double>();
            for (int i = 0; i < inputList.Length; i++)
            {
                temp = Convert.ToDouble(inputList[i]);
                doubleValue.Add(temp);
            }
            double result = doubleValue.Sum();
            Console.WriteLine("Sum of sequence : {0}",result);
            return result;
        }
        static void Main()
        {
            Console.Write("Enter sequence of numbers = ");
            string input = Console.ReadLine();
            SumSequenceOfIntegers(input);
        }
    }
}
