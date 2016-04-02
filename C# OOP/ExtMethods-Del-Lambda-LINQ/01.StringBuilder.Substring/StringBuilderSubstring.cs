namespace _01.StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //Task 1:
    //Implement an extension method Substring(int index, int length) for the class StringBuilder 
    //that returns new StringBuilder and has the same functionality as Substring in the class String.
    public class StringBuilderSubstring
    {
        public static void Main()
        {
            StringBuilder input = new StringBuilder();
            input.Append("I am studying in Telerik!");

            StringBuilder subString = new StringBuilder();
            StringBuilder newSubString = new StringBuilder();
            subString = input.SubString(0, 13);
            newSubString = input.SubString(13, 12);
            Console.WriteLine("{0} {1}", subString, newSubString);
            Console.WriteLine();
        }
    }
}
