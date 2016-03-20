using System;
class Program
{
    static void Main()
    {
        //Problem 03.Write a Boolean expression that checks for given integer if it can be divided (without remainder)
        //by 7 and 5 at the same time.
        int firstInteger;
        Console.Write("Enter value: ");
        firstInteger = int.Parse(Console.ReadLine());
        bool firstVar = (firstInteger % 7 == 0) && (firstInteger % 5 == 0) ? true : false;
        Console.WriteLine("Is divided by 7 and 5? - " + firstVar);
    }
}
