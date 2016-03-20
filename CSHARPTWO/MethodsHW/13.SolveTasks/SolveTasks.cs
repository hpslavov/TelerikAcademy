using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SolveTasks
{
//    Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0
    class SolveTasks
    {
        static List<char> ReverseDigit(string number)
        {
            decimal checkValue = decimal.Parse(number);
            if (checkValue<0)
            {
                Console.WriteLine("Wrong input! Input value should be non-negative");
                
            }
            char[] reversed = number.ToCharArray();
            List<char> temp = new List<char>();
            char value;
            for (int i = reversed.Length - 1; i >= 0; i--)
            {
                value = reversed[i];
                temp.Add(value);
            }
            Console.WriteLine(string.Join("", temp));
            return temp;

        }
        static double AverageOfSequence(string number)
        {
            if (number == string.Empty)
            {
                Console.WriteLine("Wrong input of string!!!");
            }
            string[] value = number.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            int temp = 0;
            double valueAverage = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < value.Length; i++)
            {
                temp = int.Parse(value[i]);
                result.Add(temp);
                valueAverage += temp;
            }
            valueAverage = (double)valueAverage / (double)(result.Count);
            Console.WriteLine("Average of set: {0}",valueAverage);
            return valueAverage;
            

        }
        static decimal SolveLinearEquation(decimal a,decimal b)
        {
            if (a==0 || b ==0)
            {
                Console.WriteLine("Wrong input");
            }
            decimal result = -b / a;
            Console.WriteLine("root of {0}x + ({1}) = 0  is {2}",a,b,result);
            return result;

        }
        static void Main()
        {
            Console.WriteLine("Please enter your choice:");
            Console.WriteLine("1) Reverse digits");
            Console.WriteLine("2) Calculate average of sequence of integers");
            Console.WriteLine("3) Solve linear equation");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": Console.WriteLine("Please enter digit to reverse: ");
                    string digit = Console.ReadLine();
                    ReverseDigit(digit);
                    break;
                case "2": Console.WriteLine("Please enter sequence of integers: ");
                    string sequence = Console.ReadLine();
                    AverageOfSequence(sequence);
                    break;
                case "3": Console.WriteLine("Please enter x= ");
                    decimal valueX = decimal.Parse(Console.ReadLine());
                    decimal valueB = decimal.Parse(Console.ReadLine());
                    SolveLinearEquation(valueX,valueB);

                    break;
                default: Console.WriteLine("Please enter correct choice from 1-3");
                    break;
            }
        }
    }
}
