using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _17.DateInBulgarian
{
    class DateInBulgarian
    {
        //Write a program that reads a date and time given in the format:
        //day.month.year hour:minute:second and prints the date and time after 
        //6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
        static void Main()
        {
            string input = Console.ReadLine();
            DateTime dateTime = DateTime.ParseExact(input,"dd.MM.yyyy\" \"HH:mm:ss",new CultureInfo("bg-BG"));
            dateTime = dateTime.AddHours(6).AddMinutes(30);
            string dayOfWeek = dateTime.ToString("dddd");
            Console.WriteLine("{0} {1}",dateTime,dayOfWeek);
        }
    }
}
