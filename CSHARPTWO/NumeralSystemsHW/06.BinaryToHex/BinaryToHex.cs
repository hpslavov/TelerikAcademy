using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHex
{
    class Program
    {
        //Write a program to convert binary numbers to hexadecimal numbers (directly).
        static List<string> RefactorBinaryToHex(string input)
        {
            List<string> hexFormula = new List<string>();
            List<string> binaryFormula = new List<string>();

            int counter = 0;
            string temp = string.Empty;
            for (int i = 0; i < input.Length - 3; i+=4 )
            {
                temp = Convert.ToString(input[i]) + Convert.ToString(input[i + 1]) + Convert.ToString(input[i + 2]) +
                    Convert.ToString(input[i + 3]);
                hexFormula.Add(temp);
            }
            for (int i = 0; i < hexFormula.Count; i++)
            {
                switch (hexFormula[i])
                {
                    case "0000": binaryFormula.Add("0"); break;
                    case "0001": binaryFormula.Add("1"); break;
                    case "0010": binaryFormula.Add("2"); break;
                    case "0011": binaryFormula.Add("3"); break;
                    case "0100": binaryFormula.Add("4"); break;
                    case "0101": binaryFormula.Add("5"); break;
                    case "0110": binaryFormula.Add("6"); break;
                    case "0111": binaryFormula.Add("7"); break;
                    case "1000": binaryFormula.Add("8"); break;
                    case "1001": binaryFormula.Add("9"); break;
                    case "1010": binaryFormula.Add("A"); break;
                    case "1011": binaryFormula.Add("B"); break;
                    case "1100": binaryFormula.Add("C"); break;
                    case "1101": binaryFormula.Add("D"); break;
                    case "1110": binaryFormula.Add("E"); break;
                    case "1111": binaryFormula.Add("F"); break;

                    default:
                        break;
                }
            }
            Console.WriteLine("Hexadecimal value : {0}",string.Join("",binaryFormula));
            return hexFormula;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter binary value : ");
            string input = Console.ReadLine();
            RefactorBinaryToHex(input);
        }
    }
}
