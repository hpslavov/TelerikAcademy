using System;
class PointCheck
{
    static void Main()
    {
        //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
        //and out of the rectangle R(top=1, left=-1, width=6, height=2)
        Console.Write("Enter coordinate X: ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Enter coordinate Y: ");
        double pointY = double.Parse(Console.ReadLine());
        double radius = 1.5;
        bool inCircle = (pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= radius * radius;
        bool outsideRect = ((pointX > 5) || (pointX < -1) || (pointY > 1) || (pointY < -1));
        bool check = inCircle && outsideRect;
        Console.WriteLine("Point with coordinates ({0}:{1}) is in circle and outside rectangle - {2}",pointX,pointY,check);

    }
}
