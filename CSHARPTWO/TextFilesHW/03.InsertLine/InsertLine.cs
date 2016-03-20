using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

class InsertLine
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"C:\Users\Hristo\Desktop\Method.txt");

        using (reader)
        {
            string line = reader.ReadLine();
            StreamWriter writer = new StreamWriter(@"C:\Users\Hristo\Documents\Visual Studio 2013\Projects\C#2\TextFilesHW\03.InsertLine\bin\Debug\MethodWithLines.txt");
            int lineNum = 0;
            using (writer)
            {
                while (line != null)
                {
                    lineNum++;
                    writer.WriteLine("Line {0}: {1}", lineNum, line);
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("Lines are with numbers now!");
    }
}