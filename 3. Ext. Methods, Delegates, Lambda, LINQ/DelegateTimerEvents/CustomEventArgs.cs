using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTimerEvents
{
    class CustomEventArgs : EventArgs
    {
        private string message;

        public CustomEventArgs(string str)
        {
            this.message = str;
        }

        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }
    }
}
