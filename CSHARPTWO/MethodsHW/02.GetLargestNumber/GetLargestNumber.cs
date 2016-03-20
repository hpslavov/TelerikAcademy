using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetLargestNumber
{
    class GetLargestNumber
    {
        //Write a method GetMax() with two parameters that returns the larger of two integers.
        //Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
        static int GetMax(int firstNum,int secondNum)
        {
            int largest = 0;
            if (firstNum>secondNum)
            {
                largest = firstNum;
            }
            else if (secondNum>firstNum)
            {
                largest = secondNum;
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }
            return largest;
        }
        static void Main()
        {
            Console.Write("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            int larger = GetMax(firstNumber,secondNumber);
            int moreLarger = GetMax(larger, thirdNumber);
            Console.WriteLine("Largets of three = {0}",moreLarger);
           
        }
    }
}
