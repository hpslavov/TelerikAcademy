using System;
class Program
{
    static void Main()
    {
        //Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
        Console.Write("Enter current age = ");
        int age = int.Parse(Console.ReadLine());
        int newAge = age + 10;
        Console.WriteLine("Your age after 10 years will be " + newAge);
    }
}
