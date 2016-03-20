using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYear
{
    class LeapYear
    {
        //Write a program that reads a year from the console and checks whether it is a leap one.
        //Use System.DateTime.
        static bool LeapYearCalculator(int number)
        {
            DateTime leapY = new DateTime();
            bool isLeap = false;
             isLeap = DateTime.IsLeapYear(number);
             if (isLeap == true)
             {
                 Console.WriteLine("{0} is leap year",number);
             }
             else
             {
                 Console.WriteLine("{0} is not a leap year",number);
             }
             return isLeap;

        }
        static void Main()
        {
            Console.Write("Enter year: ");
            int input = int.Parse(Console.ReadLine());
            LeapYearCalculator(input);
        }
    }
}
