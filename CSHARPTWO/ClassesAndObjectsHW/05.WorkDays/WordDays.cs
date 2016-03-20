using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace _05.WorkDays
{
    class WorkDays
    {
        //Write a method that calculates the number of workdays between today and given date, passed as parameter.
        //      Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified
        //preliminary as array.
        static List<DateTime> publicHolydays;
        static string WorkingDays (DateTime inputDate,DateTime endDate)
        {
            int workingDays = 0;
            int holyDays = 0;
            int weekEnds = 0;
            DateTime today = inputDate;
            while (today <= endDate)
            {
                if (publicHolydays.Contains(today))
                {
                    ++holyDays;
                }
                else if ((int)today.DayOfWeek == 0 || (int)today.DayOfWeek == 6)
                {
                    ++weekEnds;
                }
                else
                {
                    ++workingDays;
                }
                today = today.AddDays(1);
            }
            return String.Format("From {3} to {4}\nHolydays:{0} | WorkingDays: {1} | WeekendDays: {2}", holyDays, workingDays, weekEnds,inputDate,endDate);

        }
        static void Main(string[] args)
        {
             publicHolydays = new List<DateTime>()
            {new DateTime(2015, 3, 2),new DateTime(2015, 3, 3),new DateTime(2015, 4, 10),
            new DateTime(2015, 4, 13), new DateTime(2015, 5, 1),new DateTime(2015, 5, 6),
            new DateTime(2015, 9, 21),new DateTime(2015, 9, 22),new DateTime(2015,12,24),
            new DateTime(2015,12,25),new DateTime(2015,12,26),new DateTime(2015,12,31)};

            Console.WriteLine(WorkingDays(new DateTime(2015, 1, 1), new DateTime(2015, 11, 17)));
            //If you wanna test with other input just uncomment below :)
           // Console.WriteLine(WorkingDays(new DateTime(2015, 5, 1), new DateTime(2015, 12, 10)));
            //Console.WriteLine(WorkingDays(new DateTime(2015, 2, 15), new DateTime(2015, 6, 18)));


        }
    }
}
