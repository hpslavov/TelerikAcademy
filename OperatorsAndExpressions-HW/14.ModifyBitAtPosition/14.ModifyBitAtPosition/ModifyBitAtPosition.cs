using System;
class Program
{
    static void Main()
    {
        //We are given an integer number n, a bit value v (v=0 or 1) and a position p.
        //Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from 
        //the binary representation of n while preserving all other bits in n.
        int n;
        Console.Write("Enter number: ");
        n = int.Parse(Console.ReadLine());
        int v;
        Console.Write("Enter value (0/1): ");
        v = int.Parse(Console.ReadLine());
        int p;
        Console.Write("Enter position: ");
        p = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.Write("decimal: {0}, binary:",result);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
        }
        if (v==1)
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.Write("decimal: {0}, binary:",result);
            Console.WriteLine(Convert.ToString(result,2).PadLeft(16,'0'));
        }
    }
}
