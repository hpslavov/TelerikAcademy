using System;
class Program
{
    static void Main()
    {
        //Declare two integer variables a and b 
        //and assign them with 5 and 10 and after that exchange their values by using some programming logic.
        //Print the variable values before and after the exchange.
        int a = 5;
        Console.WriteLine("a = " + a);
        int b = 10;
        Console.WriteLine("b = " + b);
        int c=a;
        a = b;
        Console.WriteLine("Exchanged values \na = " + a);
        b = c;
        Console.WriteLine("b = " + b);
    }
}
