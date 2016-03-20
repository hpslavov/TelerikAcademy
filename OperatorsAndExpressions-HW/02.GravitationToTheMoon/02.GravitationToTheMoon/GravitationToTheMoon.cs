using System;
class GravitationToTheMoon
{
    static void Main()
    {
        //Problem 02.Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
        //The gravitational field of the Moon is approximately 17% of that on the Earth.
        int weight;
        double weightOnMoon;
        Console.Write("Enter you weight: ");
        weight = int.Parse(Console.ReadLine());
        weightOnMoon = (weight * 17) / 100.0;
        Console.WriteLine("Your weight on the Moon will be {0}", weightOnMoon);

    }
}
