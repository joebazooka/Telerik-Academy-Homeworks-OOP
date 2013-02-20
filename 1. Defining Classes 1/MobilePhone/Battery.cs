using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Battery
    {
        // Fields
        private string model;
        public BatteryType batteryType;
        private double? hoursIdle;
        private double? hoursTalk;

        // Constructors
        public Battery()
        {
            this.model = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }

        public Battery(string model)
            : this(model, new BatteryType(), null, null)
        {
            this.model = model;
        }

        public Battery(string model, BatteryType batteryType, double? hoursIdle, double? hoursTalk)
        {
            this.model = model;
            this.batteryType = batteryType;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        // Properties
        public string Model { get; set; }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set
            {
                try
                {
                    this.batteryType = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Battery Type.");
                }
            }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.hoursTalk = value;
            }
        }

        // Methods

        // ToString Method
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.model != null)
            {
                result.AppendFormat("\n\tModel: {0}", this.model);
            }

            result.AppendFormat("\n\tBattery Type: {0}", this.batteryType);

            if (this.hoursIdle != null)
            {
                result.AppendFormat("\n\tHours Idle: {0}", this.hoursIdle);
            }
            if (this.hoursTalk != null)
            {
                result.AppendFormat("\n\tHours Talk: {0}", this.hoursTalk);
            }
            
            return result.ToString();
        }
    }
}
