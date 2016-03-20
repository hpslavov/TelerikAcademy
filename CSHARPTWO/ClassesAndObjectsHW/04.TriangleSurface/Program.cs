using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleSurface
{
    class Program
    {
     //        Write methods that calculate the surface of a triangle by given:
             //Side and an altitude to it;
             //Three sides;
             //Two sides and an angle between them;
             //Use System.Math.
        static double AreaBySideAndAltitude(double sideB,double altitude)
        {
            double area = ((double)sideB * (double)altitude) / (double)2;
            Console.WriteLine("area  = {0}",area);
            return area;
        }
        static double AreaByThreeSides(double sideA,double sideB, double sideC)
        {
            double semi = (double)(sideA+sideB+sideC)/(double)2;
            double temporalValue = semi * (semi - sideA) * (semi - sideB) * (semi - sideC);
            double area = 0;
            area = Math.Sqrt(temporalValue);
            Console.WriteLine("area = {0}",area);
            return area;
        }
        static double AreaByTwoSidesAndAngle(double sideA,double sideB,double angle)
        {
            double radianAngle = (double)(angle * 3.14) / (double)180;
            double angleC = Math.Sin(radianAngle);

            double area = (double)(sideA * sideB * angleC) /(double) 2;
            //area = Math.Round(area);
            Console.WriteLine("area = {0}",area);
            return area;
        }
        static void Main()
        {
            Console.WriteLine("Calculating surface of triangle options:Select:");
            Console.WriteLine("1)Calculate by side and altitude to it:");
            Console.WriteLine("2)Calculate by three sides:");
            Console.WriteLine("3)Calculate by thwo sides and an angle between them:");


            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: Console.Write("Enter side b = ");
                        double sideB = double.Parse(Console.ReadLine());
                        Console.Write("Enter altitude  h = ");
                        double altitutde = double.Parse(Console.ReadLine());
                        AreaBySideAndAltitude(sideB,altitutde);
                        break;

                case 2: Console.Write("Enter side a = ");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter side b = ");
                    double sideBB = double.Parse(Console.ReadLine());
                    Console.Write("Enter side c = ");
                    double sideC = double.Parse(Console.ReadLine());
                    AreaByThreeSides(sideA, sideBB, sideC);
                    break;

                case 3: Console.Write("Enter side a = ");
                    double lengthA = double.Parse(Console.ReadLine());
                    Console.Write("Enter side b = ");
                    double lengthB = double.Parse(Console.ReadLine());
                    Console.Write("Enter angle c = ");
                    double angleC = double.Parse(Console.ReadLine());
                    AreaByTwoSidesAndAngle(lengthA, lengthB, angleC);
                    break;

                default:
                    break;
            }
        }
    }
}
