using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringsInCSharp
{
    class Description
    {
        static void Main(string[] args)
        {
            //Describe the strings in C#:
            //A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects.
            //There is no null-terminating character at the end of a C# string;
            //therefore a C# string can contain any number of embedded null characters ('\0').

            //What is typicall for the string data type?:
            //String objects are immutable: they cannot be changed after they have been created.
            //All of the String methods and C# operators that appear to modify a string actually return 
            //the results in a new string object.

            // Describe the most important methods of the String class.
            // Split(String[], Int32, StringSplitOptions) - Returns a string array that contains the substrings in this string that are delimited by elements of a specified string array. Parameters specify the maximum number of substrings to return and whether to return empty array elements.
            // Replace(Char, Char) - Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.
            // Substring(Int32, Int32) - Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.
            // Join(String, Object[]) - Concatenates the elements of an object array, using the specified separator between each element.
            // IndexOf(String) - Reports the zero-based index of the first occurrence of the specified string in this instance.
           
        }
    }
}
