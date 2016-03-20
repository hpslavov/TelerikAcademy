namespace EuclidianProject
{

    using System;
    using System.Text;
    using System.Reflection;
    using System.Linq;
    [VersionAttribute("2","1")]
    
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly double[] o = new double[3] { 0, 0, 0 };

        public Point3D(double x0,double y0,double z0):this()
        {
            this.X = x0;
            this.Y = y0;
            this.Z = z0;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static string PointO
        {
            get { return string.Join(", ", o); }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Point X: " + this.X);
            result.AppendLine("Point Y: " + this.Y);
            result.AppendLine("Point Z: " + this.Z);

            return result.ToString();
        }

        public static Point3D Parse(string text)
        {
            int openPar = text.IndexOf('(');
            double[] coord = text
                .Substring(openPar + 1, text.Length - openPar - 2)
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x)).ToArray();

            return new Point3D(coord[0], coord[1], coord[2]);
        }


    }
}
