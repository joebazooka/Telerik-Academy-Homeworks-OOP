using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Call
    {
        // Fields
        private DateTime date;
        private string dialedPhoneNum;
        private int duration;

        // Constructors
        public Call()
        {
            this.date = DateTime.Now;
            this.dialedPhoneNum = "-";
            this.duration = 0;
        }
        public Call(string dialedNumber, int duration)
        {
            this.date = DateTime.Now;
            this.dialedPhoneNum = dialedNumber;
            this.duration = duration;
        }
        public Call(DateTime date, string dialedNumber, int duration)
        {
            this.date = date;
            this.dialedPhoneNum = dialedNumber;
            this.duration = duration;
        }

        // Properties
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string DialedPhoneNum
        {
            get { return this.dialedPhoneNum; }
            set { this.dialedPhoneNum = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
