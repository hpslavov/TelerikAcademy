namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        public Shape()
        {

        }
        public Shape(double width,double heigth)
        {
            this.Width = width;
            this.Heigth = heigth;
        }
        public double Width { get; set; }
        public double Heigth { get; set; }

        public abstract double CalcSurface();

    }
}
