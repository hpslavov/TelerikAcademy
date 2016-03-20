using System;
class Program
{
    static void Main()
    {
        //Problem 05.Write an expression that checks for given integer if its third digit from right-to-left is 7.
        int intVariable;
        Console.Write("Enter number: ");
        intVariable = int.Parse(Console.ReadLine());
        if ( ((intVariable / 100) % 10) == 7 )
        {
            Console.WriteLine("Is 3rd digit 7? - {0}",true);
        }
        else
        {
            Console.WriteLine("Is 3rd digit 7? - {0}", false);
        }
    }
}
