using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CalculationMethods
{
    class CalculationMethods
    {
        //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        //Use variable number of arguments.

        static int CalculateMinimumOfSet(List<int> list)
        {
            int temp = 0;

            for (int i = 1; i < list.Count; i++)
            {
                int minimalValue = list[0];
                if (list[i] < minimalValue)
                {
                    temp = list[i];
                }
                else
                {
                    temp = list[0];
                }
            }
            Console.WriteLine("Minimal value : {0}", temp);
            return temp;
        }
        static int CalculateMaximumOfSet(List<int> list)
        {
            int temp = 0;
            int maxValue = list[0];
            for (int i = 1; i < list.Count; i++)
            {

                if (list[i] > maxValue)
                {
                    temp = list[i];
                    maxValue = list[i];
                }
                else
                {
                    temp = maxValue;
                }
            }
            Console.WriteLine("Maximal is: {0}", temp);
            return temp;
        }

        static double CalculateAverageOfSet(List<int> list)
        {
            double temp = 0;
            for (int i = 0; i < list.Count; i++)
            {
                temp += (double)list[i];

            }
            temp = temp / (list.Count);
            Console.WriteLine("Average of set: {0}", temp);
            return temp;
        }
        static int CalculateSumOfSet(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine("Sum of set : {0}", sum);
            return sum;

        }
        static long CalculateProductOfSet(List<int> list)
        {
            long temp = 1;
            for (int i = 0; i < list.Count; i++)
            {
                temp *= list[i];
            }
            Console.WriteLine("Product of set: {0}", temp);
            return temp;
        }

        static void Main()
        {
            //List<int> set = new List<int>() { 4, 3, 5 };
            //List<int> set = new List<int>() { 4, 3, 13,5,7 };
            List<int> set = new List<int>() { -2, 8, 5, 16, 33, 2, 0 };
            CalculateProductOfSet(set);
            CalculateSumOfSet(set);
            CalculateAverageOfSet(set);
            CalculateMaximumOfSet(set);
            CalculateMinimumOfSet(set);
        }
    }
}
