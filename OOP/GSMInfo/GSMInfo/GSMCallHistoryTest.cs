namespace GSMInfo
{
    using System;
    using System.Collections.Generic;
    public class GSMCallHistoryTest
    {
        private GSMInfo newPhone = new GSMInfo("S4", "Samsung");
        private List<Call> calls = new List<Call>();
        


        public void CallHistoryTest(int tests)
        {
            newPhone.CallHistory = calls;
            for (int i = 0; i < tests; i++)
            {
                Call newCall = new Call(DateTime.Now, DateTime.Now, "0885 525 635", i + 50);
                newPhone.CallHistory.Add(newCall);
            }

            for (int i = 0; i < newPhone.CallHistory.Count; i++)
            {
                Console.WriteLine("Date and Time of Call: {0:MM/dd/yy}", calls[i].Date);
                Console.WriteLine("PhoneNumber : {0}", calls[i].PhoneNumber);
                Console.WriteLine("Duration: {0}", calls[i].Duration);
                Console.WriteLine("Time of call: {0:H:mm:ss}", calls[i].Time);
            }
            decimal currentPrice = 0.37m;
            decimal price = newPhone.CalculateCallPrice(calls, currentPrice);

            Console.WriteLine(price);
            Call longestCall = new Call(DateTime.Now, DateTime.Now, "0885 525 635", 0);

            for (int i = 0; i < newPhone.CallHistory.Count; i++)
            {
                if (calls[i].Duration >= longestCall.Duration)
                {
                    longestCall = calls[i];
                }
            }

            newPhone.RemoveCalls(longestCall);
            decimal editedPrice = newPhone.CalculateCallPrice(calls, currentPrice);
            Console.WriteLine(editedPrice);

            newPhone.ClearHistory();

            Console.WriteLine(newPhone.CalculateCallPrice(calls,currentPrice));

        }





    }
}
