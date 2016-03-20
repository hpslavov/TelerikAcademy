namespace _01.Shapes
{
    using System;

    public class Rectangle: Shape
    {
        public Rectangle(double width,double heigth):base(width,heigth)
        {

        }

        public override double CalcSurface()
        {
            return this.Width * this.Heigth;
        }
    }
}
