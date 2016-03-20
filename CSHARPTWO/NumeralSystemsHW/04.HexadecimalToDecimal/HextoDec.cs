using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexadecimalToDecimal
{
    class HextoDec
    {
        static double RefactorHexToDecimal(string input)
        {
            List<char> decFormula = new List<char>();
            List<double> HexNumber = new List<double>();
            List<double> result = new List<double>();

            double temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                decFormula.Add(input[i]);
            }
            for (int i = 0; i < decFormula.Count; i++)
            {
                if (decFormula[i] > -1)
                {
                    switch (decFormula[i])
                    {
                        case '0': HexNumber.Add(0); break;
                        case '1': HexNumber.Add(1); break;
                        case '2': HexNumber.Add(2); break;
                        case '3': HexNumber.Add(3); break;
                        case '4': HexNumber.Add(4); break;
                        case '5': HexNumber.Add(5); break;
                        case '6': HexNumber.Add(6); break;
                        case '7': HexNumber.Add(7); break;
                        case '8': HexNumber.Add(8); break;
                        case '9': HexNumber.Add(9); break;

                        default:
                            break;
                    }
                }
                if (decFormula[i] > 9)
                {
                    switch (decFormula[i])
                    {
                        case 'A': HexNumber.Add(10); break;
                        case 'B': HexNumber.Add(11); break;
                        case 'C': HexNumber.Add(12); break;
                        case 'D': HexNumber.Add(13); break;
                        case 'E': HexNumber.Add(14); break;
                        case 'F': HexNumber.Add(15); break;

                        default:
                            break;
                    }
                }
            }
            HexNumber.Reverse();
            for (int i = 0; i < HexNumber.Count; i++)
            {
                temp += HexNumber[i] * Math.Pow(16, i);
                
            }


            //Console.WriteLine(string.Join(" ", HexNumber));
            Console.WriteLine("Decimal value : {0}",temp);
            return temp;
        }
        //Write a program to convert hexadecimal numbers to their decimal representation.
        static void Main()
        {
            Console.Write("Enter hexadecimal number : ");
            string input = Console.ReadLine();
            RefactorHexToDecimal(input);

        }
    }
}
