using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTimerEvents
{
    class Timer
    {
        public delegate void ToExecute();

        private ToExecute methods;
        private int seconds;
        private System.DateTime stop;
        public event EventHandler SecondPassed;

        public Timer(int seconds)
        {
            this.seconds = seconds;
        }

        public ToExecute Methods
        {
            get
            {
                return this.methods;
            }
            set
            {
                this.methods = value;
            }
        }

        public int Seconds
        {
            get
            {
                return this.seconds;
            }
        }

        public void Execute()
        {
            this.stop = DateTime.Now.AddSeconds(this.seconds);

            while (DateTime.Now < stop)
            {
                OnSecondPassed(new EventArgs());
                System.Threading.Thread.Sleep(1000);
            }
        }

        protected virtual void OnSecondPassed(EventArgs e)
        {
            EventHandler handler = SecondPassed;

            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
