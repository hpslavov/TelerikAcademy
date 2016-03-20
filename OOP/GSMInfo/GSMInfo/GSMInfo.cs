using System;
using System.Collections.Generic;
using System.Text;

namespace GSMInfo
{
    public class GSMInfo
    {
        private static GSMInfo Iphone4S = new GSMInfo("Iphone4S", "Apple");
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery batteryModel;
        private Display display;
        private Call call;

        private List<Call> callHistory;

        public GSMInfo(): this(null,null,null,0)
        {

        }
        public GSMInfo(string model,string manufacturer, string owner,decimal price): this(model,manufacturer)
        {
            this.Owner = owner;
            this.Price = price;

        }

        public GSMInfo(string model,string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Display = new Display();
            this.BatteryModel = new Battery();
            
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Manufacturer name must not be empty");
                }
                this.manufacturer = value;
            }
                
        }
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Phone model:Name must not be empty");
                }
                this.model = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Owner name cannot be empty");
                }
                this.owner = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 1 )
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less than 1");
                }
                this.price = value;
            }
            
        }

       

       public GSMInfo Iphone4SInfo
        {
            get { return Iphone4S; }
        }

        public Battery BatteryModel
       {
           get { return this.batteryModel; }
           set { this.batteryModel = value; }
       }

       public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public override string ToString()
        {
            StringBuilder overAll = new StringBuilder();

            overAll.AppendLine("Manufacturer: " + this.Manufacturer);
            overAll.AppendLine("Model: " + this.Model);
            overAll.AppendLine("Price: " + this.Price);
            overAll.AppendLine("Owner: " + this.Owner);
            overAll.AppendLine("Battery: Type:"  + this.BatteryModel.BatteryType + ", HoursIdle: " + this.BatteryModel.BatteryHoursIdle + ", HoursTalk:" + this.BatteryModel.BatteryHoursTalk);
            overAll.AppendLine("Display: DisplayColors: " + this.Display.Colors + ", DisplaySizeInch: " + this.Display.Size);

            return overAll.ToString();
        } 

        public Call Call
        {
            get { return this.call; }
            set {this.call = new Call(); }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public void AddCalls(Call newcall)
        {
            callHistory.Add(newcall);
        }

        public void RemoveCalls(Call currentCall)
        {
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                if (currentCall.Duration == CallHistory[i].Duration && currentCall.Time == CallHistory[i].Time && currentCall.Date == CallHistory[i].Date && currentCall.PhoneNumber == CallHistory[i].PhoneNumber)
                {
                    CallHistory.RemoveAt(i);
                }
            }
        }

        public void ClearHistory()
        {
            CallHistory.Clear();
        }

        public decimal CalculateCallPrice(List<Call> callHistory, decimal price)
        {
            decimal  result = 0;

            foreach (var item in callHistory)
            {
                result += ((decimal)item.Duration / 60) * price;
            }

            return result;
        }
    }
}
