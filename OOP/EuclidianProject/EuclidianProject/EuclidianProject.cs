using System;
using System.Collections.Generic;
namespace EuclidianProject
{
    public class EuclidianProject
    {
        static void Main()
        {
            Path path = new Path();
            string filepath = @"../../Method.txt";
            Path newPath = new Path();
            PathStorages.SavePath(path, filepath);
            path = PathStorages.LoadPath(filepath);

            //Console.WriteLine("Version: {0}",typeof(Class).GetCustomAttributes(true));//test attributes
        }
    }
}