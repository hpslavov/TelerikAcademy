﻿using System;
using System.IO;

//Write a program that concatenates two text files into another text file.

class ConcatenateTextFiles
{
    static void Main()
    {
        using (StreamWriter write = new StreamWriter(@"C:\Users\Hristo\Documents\Visual Studio 2013\Projects\C#2\TextFilesHW\02.ConcatenateTextFiles\bin\Debug\test.txt", true))
        {
            using (StreamReader firstReader = new StreamReader(@"C:\Users\Hristo\Desktop\Method.txt"))
            {
                string line = firstReader.ReadLine();
                while (line != null)
                {
                    write.WriteLine(line);
                    line = firstReader.ReadLine();
                }
            }

            using (StreamReader secondReader = new StreamReader(@"C:\Users\Hristo\Desktop\Zerg!!!.txt"))
            {
                string line = secondReader.ReadLine();
                while (line != null)
                {
                    write.WriteLine(line);
                    line = secondReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Concatenation is done.");
    }
}