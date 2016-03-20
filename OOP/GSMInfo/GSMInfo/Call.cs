namespace GSMInfo
{
    using System;
    using System.Collections.Generic;

    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string phoneNumber;
        private int duration;


        public Call(DateTime date, DateTime time, string phoneNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        public Call()
        {

        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        
    }
}
