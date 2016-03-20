using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static int RefactorBinaryToDecimal(int value)
        {
            string strValue = value.ToString();
            List<int> decimalFormula = new List<int>();
            int temp = 0;
            for (int i = 0; i < strValue.Length; i++)
            {
                temp = strValue[i] - '0';
                decimalFormula.Add(temp);


            }
            int refactorOne = 0;
            decimalFormula.Reverse();
            for (int i = decimalFormula.Count-1; i >= 0; i--)
            {
                refactorOne += decimalFormula[i] * (int)Math.Pow(2, i);
            }

            Console.WriteLine(refactorOne);
            //Console.WriteLine(string.Join("",decimalFormula));
            return refactorOne;
        }
        static void Main()
        {
            //Write a program to convert binary numbers to their decimal representation.
            Console.Write("Enter binary number : ");
            int number = int.Parse(Console.ReadLine());
            RefactorBinaryToDecimal(number);
        }
    }
}
