using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReverseSentence
{
    class ReverseSentence
    {
        //Write a program that reverses the words in given sentence.
        //Example:C# is not C++, not PHP and not Delphi!

        //Output:Delphi not and PHP, not C++ not is C#!
        static string ReverseSentences(string input)
        {
            string inputOne = string.Empty;
            string inputtwo = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',')
                {
                    int startIndex = input.IndexOf(input[0]);
                    int indexOfComma = input.IndexOf(',');
                    inputOne = input.Substring(startIndex,indexOfComma - startIndex);
                }
                if (input[i] == '!')
                {
                    int indexOfExpr = input.IndexOf('!');
                    inputtwo = input.Substring(input.IndexOf(',')+1, input.IndexOf('!') - input.IndexOf(',')-1);
                }
                
            }
            List<string> listOne = new List<string>();
            listOne = inputOne.Split().ToList<string>();
            listOne.Add("");
            listOne.Reverse();
            List<string> listTwo = new List<string>();
            listTwo = inputtwo.Split().ToList<string>();
            listTwo.Remove("");
            listTwo.Reverse();

            string result = string.Join(" ",listTwo) + "," + string.Join(" ",listOne) + "!";
            Console.WriteLine(result);
            return result;

        }
        static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            ReverseSentences(input);
        }
    }
}
