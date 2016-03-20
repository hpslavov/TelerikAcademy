namespace _01.Shapes
{
    using System;
    public class Square:Shape
    {
        public Square(double width):base(width,width)
        {

        }

        public override double CalcSurface()
        {
            return this.Width * this.Width;
        }
    }
}
