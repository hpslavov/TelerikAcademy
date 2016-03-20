using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class OddLines
    {
        //Write a program that reads a text file and prints on the console its odd lines.
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Hristo\Desktop\Method.txt"))//Enter path to text file
            {
                int lineNum = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNum % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    lineNum++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
