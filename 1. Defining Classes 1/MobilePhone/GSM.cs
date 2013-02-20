using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSM
    {
        // Fields
        private static GSM iPhone4S = new GSM("IPhone 4S", "Apple", 1149.90, "Pesho",
            new Battery("Apple Battery", BatteryType.LiIon, 200, 8), new Display(960, 640, 16000000));

        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;

        private List<Call> callHistory = new List<Call>();

        // Constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        // Properties
        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.manufacturer = value;
            }
        }

        public double? Price { get; set; }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        // Methods

        // ToString Method
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Model: {0}\n", this.model);
            result.AppendFormat("Manufacturer: {0}\n", this.manufacturer);
            if (this.price != null)
            {
                result.AppendFormat("Price: {0:C}\n", this.price);
            }
            if (this.owner != null)
            {
                result.AppendFormat("Owner: {0}\n", this.owner);
            }
            if (this.battery != null)
            {
                result.AppendFormat("Battery: {0}\n", this.battery);
            }
            if (this.display != null)
            {
                result.AppendFormat("Display: {0}\n", this.display);
            }

            return result.ToString();
        }

        // Add Call to Call History
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        // Delete Call from Call History
        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        // Delete Longest Call from Call History
        public void DeleteLongestCall()
        {
            if (this.callHistory.Count == 0)
            {
                throw new InvalidOperationException();
            }
            int ind = -1;
            int counter = 0;
            int maxDuration = 0;
            foreach (Call call in callHistory)
            {
                if (call.Duration > maxDuration)
                {
                    maxDuration = call.Duration;
                    ind = counter;
                }
                counter++;
            }

            if (ind<0)
            {
                this.callHistory.RemoveAt(0);
            }
            else
            {
                this.callHistory.RemoveAt(ind);
            }
        }

        // Clear Call History
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
            Console.WriteLine("Call History Cleared.");
        }

        // Calculates Total Price for Calls
        public decimal TotalPrice(double pricePerMinute)
        {
            long totalMinutes = 0;

            foreach (Call call in callHistory)
            {
                totalMinutes += (long)Math.Ceiling((double)call.Duration / 60);
            }

            decimal price = (decimal)(totalMinutes * pricePerMinute);

            return price;
        }

        // Displays Info for each Call in Call History
        public string CallHistoryInfo()
        {
            StringBuilder result = new StringBuilder();
            if (this.callHistory.Count == 0)
            {
                result.Append("/nEmpty/n");
                return result.ToString();
            }
            foreach (Call call in callHistory)
            {
                result.AppendFormat("\nDate: {0}\nDialed: {1}\nDuration (in seconds): {2}\n",
                    call.Date, call.DialedPhoneNum, call.Duration);
            }

            return result.ToString();
        }
    }
}
