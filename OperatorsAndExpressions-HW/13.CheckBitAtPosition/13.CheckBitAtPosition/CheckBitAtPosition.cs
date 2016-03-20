using System;
class Program
{
    static void Main()
    {
        //Write a Boolean expression that returns if the bit
        //at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
        int n;
        Console.Write("Enter number: ");
        n = int.Parse(Console.ReadLine());
        int p;
        Console.Write("Enter bit position: ");
        p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int andMask = n & mask;
        int bitResult = andMask >> p;
        bool result = true;
        if (bitResult == 1)
	    {
            Console.WriteLine(result);
	    }
        else
        {
            Console.WriteLine(false);
        }
    }
}
