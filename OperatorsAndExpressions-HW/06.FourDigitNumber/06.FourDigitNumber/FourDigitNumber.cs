using System;
class FourDigitNumber
{
    static void Main()
    {
        //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        //Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        //Prints on the console the number in reversed order: dcba (in our example 1102).
        //Puts the last digit in the first position: dabc (in our example 1201).
        //Exchanges the second and the third digits: acbd (in our example 2101).
        int enterDigit;
        int fourthDigit;
        int thirdDigit;
        int secondDigit;
        int firstDigit;
        int sumDigit;
        Console.Write("Enter four-digit number:");
        enterDigit = int.Parse(Console.ReadLine());
        fourthDigit = enterDigit % 10;

        thirdDigit = enterDigit / 10;
        thirdDigit = thirdDigit % 10;

        secondDigit = enterDigit / 100;
        secondDigit = secondDigit % 10;

        firstDigit = enterDigit / 1000;
        firstDigit = firstDigit % 10;

        sumDigit = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine("The sum of digits: {0}",sumDigit);
        Console.WriteLine("Digit in reverse : {0}{1}{2}{3}",fourthDigit,thirdDigit,secondDigit,firstDigit);
        Console.WriteLine("Last digit in first position {0}{1}{2}{3}",fourthDigit,firstDigit,secondDigit,thirdDigit);
        Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}",firstDigit,thirdDigit,secondDigit,fourthDigit);


    }
}
