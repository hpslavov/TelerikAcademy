using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _16.DateDifference
{
    class DateDifference
    {
        //Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
        static void Main()
        {
            Console.Write("Enter start Date : ");
            string startingDate = Console.ReadLine();
            Console.Write("Enter end Date : ");
            string endingDate = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(startingDate, "d.M.yyyy",CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endingDate,"d.M.yyyy",CultureInfo.InvariantCulture);
            double days = Math.Abs((endDate - startDate).TotalDays);
            Console.WriteLine("From {0} to {1} are {2} days",startDate,endDate,days);
        }
    }
}
