namespace EuclidianProject
{
    using System;
    using System.Text;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Reflection;
    [VersionAttribute("2","4")]

    public static class PathStorages
    {
        public static void SavePath(Path path, string filePath)
        {
            using (var stream = new StreamWriter(filePath))
            {
                foreach (var point in path)
                {
                    stream.WriteLine(point);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();
            using (var reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Point3D point = Point3D.Parse(line);
                    path.Add(point);
                }
            }
            return path;
        }
    }
}


