namespace _02.StudentAndWorkers
{
    using System;

    public class Worker: Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName,string lastName,decimal weekSalary,int wHours): base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = wHours;
        }
        
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid salary value!");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }

            private set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Invalid working hours!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.weekSalary / (5m * WorkHoursPerDay);
        }

    }
}
