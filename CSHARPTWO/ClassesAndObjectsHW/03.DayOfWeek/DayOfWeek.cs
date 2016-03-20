using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        //Write a program that prints to the console which day of the week is today.
        //Use System.DateTime.
        static void Main()
        {
            DateTime today = DateTime.Now;

            DateTime addDay = today.AddDays(2);
            Console.WriteLine("Today is: {0:dddd}",today);
            Console.WriteLine("After two days is : {0}",addDay);
        }
    }
}
