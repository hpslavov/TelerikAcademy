namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Triangle : Shape
    {
        public Triangle(double a, double b):base(a,b)
        {

        }

        public override double CalcSurface()
        {
            return (double)(this.Width * this.Heigth) / (double)2;
        }
    }
}
