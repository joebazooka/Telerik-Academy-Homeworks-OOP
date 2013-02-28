using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTimerEvents
{
    class Subscriber
    {
        private string id;
        private Timer timer;
        public Subscriber(string ID, Timer timer)
        {
            this.id = ID;
            this.timer = timer;
            
            timer.SecondPassed += HandleCustomEvent;
        }
 
        void HandleCustomEvent(object sender, EventArgs e)
        {
            this.timer.Methods();
        }
    }
}
