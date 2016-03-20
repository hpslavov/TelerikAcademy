using System;
class PrimeNumberCheck
{
    static void Main()
    {
        //Write an expression that checks if given positive integer number n (n = 100) is prime 
        //(i.e. it is divisible without remainder only to itself and 1).
        int intPrime;
        Console.Write("Enter number: ");
        intPrime = int.Parse(Console.ReadLine());
        bool primeNumbers = intPrime == 1 || intPrime == 2 || intPrime == 3 || intPrime == 5 || intPrime == 7;
        bool primeDivider = intPrime % 2 != 0 && intPrime % 3 != 0 && intPrime % 5 != 0 && intPrime % 7 != 0;
        if (primeNumbers ^ primeDivider)
        {
            Console.WriteLine("{0} number is prime", intPrime);
        }
        else
        {
            Console.WriteLine("{0} number is not prime", intPrime);
        }
       
    }
}
