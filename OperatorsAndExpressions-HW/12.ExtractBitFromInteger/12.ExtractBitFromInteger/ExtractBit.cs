using System;
class ExtractBit
{
    static void Main()
    {
        //Write an expression that extracts from given integer n the value of given bit at index p.
        int intNumber;
        Console.Write("Enter number: ");
        intNumber = int.Parse(Console.ReadLine());
        int bitposition;
        Console.Write("Enter bit position: ");
        bitposition = int.Parse(Console.ReadLine());
        int mask = 1 << bitposition;
        int andMask = intNumber & mask;
        int result = andMask >> bitposition;
        Console.WriteLine("The bit at position {0} is {1}",bitposition,result);
    }
}
