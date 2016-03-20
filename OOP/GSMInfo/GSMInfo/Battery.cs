namespace GSMInfo
{
    using System;

    public class Battery
    {
        private string batteryModel;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        public Battery()
        {
            
        }

        public Battery(string batteryModel,int hoursIdle,int hoursTalk,BatteryType batteryType)
        {
            this.BatteryType = batteryType;
            this.BatteryHoursIdle = hoursIdle;
            this.BatteryHoursTalk = hoursTalk;
            this.BatteryModel = batteryModel;
        }
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public int BatteryHoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be less than zero!");

                }
                this.hoursIdle = value;
            }
        }

        public int BatteryHoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be less than zero!");

                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set
            {

                this.batteryType = value;
            }
        }


    }
}
