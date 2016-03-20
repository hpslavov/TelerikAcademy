using System;
class ComparingFloats
{
    static void Main()
    {
        //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
        double firstVar;
        double secondVar;
        string firstInput;
        string secondInput;
        double eps;
        Console.Write("Enter firstNumber:");
        firstInput = Console.ReadLine();
        Console.Write("Enter secondNumber:");
        secondInput = Console.ReadLine();
        firstVar = double.Parse(firstInput);
        secondVar = double.Parse(secondInput);
        eps = Math.Abs(firstVar - secondVar);
        if (eps < 0.000001)
        {
            Console.WriteLine("{0} and {1} are equal", firstVar, secondVar);
        }
        else
        {
            Console.WriteLine("{0} and {1} are different", firstVar, secondVar);
        }
    }
}
