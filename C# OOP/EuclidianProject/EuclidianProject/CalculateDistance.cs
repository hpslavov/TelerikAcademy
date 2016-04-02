namespace EuclidianProject
{
    using System;
    using System.Reflection;
    [VersionAttribute("2","3")]
    public static class CalculateDistance 
    {
        public static double CalculateDistanceBetween(Point3D firstPoint, Point3D secondPoint) // task 3
       {
           double result = 0;
           result = Math.Sqrt(
               (firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) +
               (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) +
               (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));
           return result;
       }
    }
}
