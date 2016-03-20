using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringss = Console.ReadLine();
            List<char> chars = new List<char>();
            for (int i = 0; i < stringss.Length; i++)
            {
                chars.Add(stringss[i]);
            }
            Console.WriteLine(string.Join("", chars));
            
            chars.Reverse();
            Console.WriteLine(string.Join("", chars));

        }
    }
}
