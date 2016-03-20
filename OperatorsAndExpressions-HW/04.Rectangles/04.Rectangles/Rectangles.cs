using System;
class Rectangles
{
    static void Main()
    {
        //Problem 04.Write an expression that calculates rectangle’s perimeter and area by given width and height.
        double firstSide;
        double secondSide;
        double rectanglePerimeter;
        double rectangleArea;
        Console.Write("Enter side a of rectangle: ");
        firstSide = double.Parse(Console.ReadLine());
        Console.Write("Enter side b of rectangle: ");
        secondSide = double.Parse(Console.ReadLine());
        rectanglePerimeter = (2 * firstSide) + (2 * secondSide);
        Console.WriteLine("Perimeter is: " + rectanglePerimeter);
        rectangleArea = firstSide * secondSide;
        Console.WriteLine("Area is: " + rectangleArea);
    }
}
