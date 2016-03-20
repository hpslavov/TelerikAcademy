using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexadecimalToBinary
{
    class HexToBin
    {
        static List<string> RefactorHexToBinary(string input)
        {
            List<char> binaryFormula = new List<char>();
            List<string> result = new List<string>();
            char temp;
            for (int i = 0; i < input.Length; i++)
            {
                temp = input[i];
                binaryFormula.Add(temp);
            }
            for (int i = 0; i < binaryFormula.Count; i++)
            {
                switch (binaryFormula[i])
                {
                    case '0': result.Add("0000"); break;
                    case '1': result.Add("0001"); break;
                    case '2': result.Add("0010"); break;
                    case '3': result.Add("0011"); break;
                    case '4': result.Add("0100"); break;
                    case '5': result.Add("0101"); break;
                    case '6': result.Add("0110"); break;
                    case '7': result.Add("0111"); break;
                    case '8': result.Add("1000"); break;
                    case '9': result.Add("1001"); break;
                    case 'A': result.Add("1010"); break;
                    case 'B': result.Add("1011"); break;
                    case 'C': result.Add("1100"); break;
                    case 'D': result.Add("1101"); break;
                    case 'E': result.Add("1110"); break;
                    case 'F': result.Add("1111"); break;

                    default: break;
                }
                
            }
            Console.WriteLine("binary: {0}",string.Join("",result));
            return result;
        }
        //Write a program to convert hexadecimal numbers to binary numbers (directly).
        static void Main()
        {
                Console.Write("Enter binary value : ");
                string input = Console.ReadLine();
                RefactorHexToBinary(input);
        }
    }
}
