using System;
class Program
{
    static void Main()
    {
        //Create a program that assigns null values to an integer and to a double variable.
        //Try to print these variables at the console.
        //Try to add some number or the null literal to these variables and print the result.

        int? intVariable = null;
        double? doubleVariable = null;

        Console.WriteLine("integerVariable value: {0}", intVariable);
        Console.WriteLine("doubleVariable value: {0}",doubleVariable);

        intVariable = intVariable.GetValueOrDefault();
        doubleVariable = doubleVariable.GetValueOrDefault();

        Console.WriteLine("showing the  int value with GetValueOrDefault: {0}",intVariable);
        Console.WriteLine("showing the double value with GetValueOrDefault: {0}",doubleVariable);

        intVariable = intVariable.GetValueOrDefault() + 20;
        doubleVariable = doubleVariable.GetValueOrDefault() + 20.4;

        Console.WriteLine("added value to integerVariable: {0}", intVariable);
        Console.WriteLine("added value ot doubleVariable: {0}", doubleVariable);
    }
}
