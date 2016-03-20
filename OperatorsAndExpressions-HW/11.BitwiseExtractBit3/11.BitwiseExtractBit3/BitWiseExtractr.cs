using System;
class Program
{
    static void Main()
    {
        //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
        uint uintNumber;
        uint mask;
        Console.Write("Enter number: ");
        uintNumber = uint.Parse(Console.ReadLine());
        mask = 1 << 3;
        uint andMask = mask & uintNumber;
        uint result = andMask >> 3;
        Console.WriteLine("The #3rd bit of {0} is {1}",uintNumber,result);
    }
}
