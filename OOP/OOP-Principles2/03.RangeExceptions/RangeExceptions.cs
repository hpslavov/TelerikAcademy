//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and 
//InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
namespace _03.RangeExceptions
{
    using System;
    using System.Globalization;
    
    public class RangeExceptions
    {
        public static void Main(string[] args)
        {
            Console.Write("Ennter number: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 100)
            {
                throw new InvalidRangeException<int>("Number cannot be less than 1 or more than 100", 1, 100);
            }

            Console.Write("Enter date (dd/mm/yyyy): ");
            DateTime testDate = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);

            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);

            if (testDate < start || testDate > end)
            {
                throw new InvalidRangeException<DateTime>("Input date must be in range [1980,1,1]-[2013,12,31]", start, end);
            }


        }
    }
}
