using System;
class Program
{
    static void Main()
    {
        //Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
        Console.Write("Enter x:");
        double xVar = double.Parse(Console.ReadLine());
        Console.Write("Enter y:");
        double yVar = double.Parse(Console.ReadLine());
        bool inSide = ((xVar * xVar) + (yVar * yVar)) <= (2 * 2);
        Console.WriteLine("Point ({0},{1}) is inside circle (0,2) - {2}",xVar,yVar,inSide);
    }
}
