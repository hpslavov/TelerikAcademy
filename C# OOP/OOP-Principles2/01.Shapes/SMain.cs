//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define class Square and suitable constructor so that at initialization height
//must be kept equal to width and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for 
//different shapes (Square, Rectangle, Triangle) stored in an array.
namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SMain
    {
        static void Main()
        {
            var shapes = new List<Shape>()
            {
                new Square(5.0),
                new Rectangle(6,4),
                new Triangle(12,6),
                new Square(17)
            };
            foreach (var sh in shapes)
            {
                Console.WriteLine(sh.CalcSurface());
            }

        }
    }
}
