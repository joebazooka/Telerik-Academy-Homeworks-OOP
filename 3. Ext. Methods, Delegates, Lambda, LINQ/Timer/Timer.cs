using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Timer
    {
        public delegate void ToExecute();

        private ToExecute methods;
        private int seconds;
        private System.DateTime stop;

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
                this.methods();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
