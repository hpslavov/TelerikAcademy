using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        //Write a program to convert decimal numbers to their hexadecimal representation.
        static List<string> RefactorDecimalToHex(int value)
        {
            string strValue = value.ToString();
            List<char> HexFormula = new List<char>();
            char temp;
            int temporaryDivider;
            for (int i = 0; i < strValue.Length; i++)
            {
                temp = strValue[i];
                HexFormula.Add(temp);
            }
            List<string> HexNumber = new List<string>();

            while (value>0)
            {
                temporaryDivider = value % 16;
                HexNumber.Add(Convert.ToString(temporaryDivider));
                value = value / 16;
                
            }
            HexNumber.Reverse();
            for (int i = 0; i < HexNumber.Count; i++)
            {
                if (HexNumber[i] == "10")
                {
                    HexNumber[i] = "A";
                }
                if (HexNumber[i] == "11")
                {
                    HexNumber[i] = "B";
                }
                if (HexNumber[i] == "12")
                {
                    HexNumber[i] = "C";
                }
                if (HexNumber[i] == "13")
                {
                    HexNumber[i] = "D";
                }
                if (HexNumber[i] == "14")
                {
                    HexNumber[i] = "E";
                }
                if (HexNumber[i] == "15")
                {
                    HexNumber[i] = "F";
                }

            }
            Console.WriteLine(string.Join("",HexNumber));
            return HexNumber;
        }
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            int number = int.Parse(Console.ReadLine());
            RefactorDecimalToHex(number);
        }
    }
}
