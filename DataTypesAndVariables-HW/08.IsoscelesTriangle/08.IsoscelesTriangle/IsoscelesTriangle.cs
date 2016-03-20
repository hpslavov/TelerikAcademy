using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main()
    {
        //Write a program that prints an isosceles triangle of 9 copyright symbols ©
        string copyRSymbol = "\u00A9";
        Console.WriteLine(@"
     {0}

    {0} {0}

   {0}   {0}

  {0} {0} {0} {0},",copyRSymbol);
    }
}
