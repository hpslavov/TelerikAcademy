using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{
    class ParseURL
    {
        //Write a program that parses an URL address given in the format:
        //[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

        static int IndexOfOccurence(string s, string match, int occurence)
        {
            int i = 1;
            int index = 0;

            while (i <= occurence && (index = s.IndexOf(match, index + 1)) != -1)
            {
                if (i == occurence)
                    return index;

                i++;
            }

            return -1;
        }
        static void GetInformationOfURL(string input)
        {
            string protocol = string.Empty;
            string server = string.Empty;
            string resource = string.Empty;
            string result = string.Empty;
            int protocolIndex = input.IndexOf(':');
            int startIndex = input.IndexOf(input[0]);
            int thirdIndex = IndexOfOccurence(input,"/",3);
            int secondIndex = IndexOfOccurence(input, "/", 2);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ':')
                {
                    protocol = input.Substring(startIndex,protocolIndex - startIndex);
                    startIndex = protocolIndex + 2;
                }

                if (i == thirdIndex)
                {
                    server = input.Substring(secondIndex + 1,thirdIndex - secondIndex - 1);
                    startIndex = startIndex + 1;
                }

                
            }
            resource = input.Substring(thirdIndex,input.Length - thirdIndex);

            Console.WriteLine("[protocol] {0}\n[server] {1}\n[resource] {2}",protocol,server,resource);
            
        }

        static void Main()
        {
            string input = "https://telerikacademy.com/Courses/Courses/Details/212";
            Console.WriteLine(input);
            GetInformationOfURL(input);
        }
    }
}
