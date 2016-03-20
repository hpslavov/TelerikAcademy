using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecimalToBinary
{
    class DecimalToBinary
    {
        //Write a program to convert decimal numbers to their binary representation.
        static List<int> RefactorDecimalToBinary(int number)
        {
            List<int> binaryList = new List<int>();
            int temp = 1;
            bool isTrue = true;
            while (number>0)
            {
                temp = number % 2;
                number /= 2;
                
                if (temp == 0)
                {
                    binaryList.Add(0);
                }
                if (temp != 0)
                {
                    binaryList.Add(1);
                }
            }
           
            Console.WriteLine(string.Join("", binaryList));
            return binaryList;
        }
        static void Main()
        {
            Console.Write("Enter decimal number :");
            int number = int.Parse(Console.ReadLine());
            RefactorDecimalToBinary(number);

        }
    }
}
