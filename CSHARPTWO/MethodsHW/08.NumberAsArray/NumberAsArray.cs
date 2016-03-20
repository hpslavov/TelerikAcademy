using System;
using System.Collections.Generic;

namespace ArrayOfDigit
{
    class Program
    {
//        Write a method that adds two positive integer numbers represented as arrays of digits (
        //each array element arr[i] contains a digit; the last digit is kept in arr[0]).
        //Each of the numbers that will be added could have up to 10 000 digits.
        static void Main(string[] args)
        {
            List<byte> firstNumber = new List<byte> { 1, 9, 7, 5, 9 };
            List<byte> secondNumber = new List<byte> { 1, 2 };

            FixTheEmptyPosition(firstNumber, secondNumber);
            SumDigit(firstNumber, secondNumber);
        }
        static void SumDigit(List<byte> a, List<byte> b)
        {
            List<byte> newList = new List<byte>();
            int length = a.Count;
            byte add = 0;  

            for (int i = 0; i < length; i++)
            {
                if ((byte)(a[i] + b[i] + add) < 10)
                {
                    byte temp = (byte)(a[i] + b[i] + add);
                    newList.Add(temp);
                    add = 0;
                }
                else
                {
                    int temp = (byte)((a[i] + b[i] + add) % 10);  
                    add = (byte)((a[i] + b[i] + add) / 10);       
                    newList.Add((byte)temp);
                }
            }
            if (add == 1)
            {
                newList.Add(1);
            }

            newList.Reverse();  
            Console.WriteLine(string.Join("", newList));
        }
       
        private static void FixTheEmptyPosition(List<byte> a, List<byte> b)
        {
            int lengthMin = Math.Min(a.Count, b.Count);
            int lengthMax = Math.Max(a.Count, b.Count);
            a.Reverse();  
            b.Reverse();  

            if (lengthMax != lengthMin)  
            {
                for (int i = lengthMin; i < lengthMax; i++)
                {
                    if (a.Count < b.Count)
                    {
                        a.Add(0);   
                    }
                    else
                    {
                        b.Add(0);
                    }
                }
            }
        }
    }
}