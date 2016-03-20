using System;
class Program
{
    static void Main()
    {
        //Write an expression that calculates trapezoid's area by given sides a and b and height h.
        double sideA;
        double sideB;
        double heightH;
        Console.Write("Enter side a: ");
        sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter height h: ");
        heightH = double.Parse(Console.ReadLine());
        double trapezoidArea = ((sideA + sideB)*heightH)/2;
        Console.WriteLine("Trapezoids area is {0}",trapezoidArea);
    }
}
