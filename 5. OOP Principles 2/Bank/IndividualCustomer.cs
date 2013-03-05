using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class IndividualCustomer : Customer
    {
        // Fields
        private string egn;

        // Constructor
        public IndividualCustomer()
            : this(string.Empty, string.Empty) { }

        public IndividualCustomer(string name, string phoneNumber)
            : this(name, phoneNumber, string.Empty) { }

        public IndividualCustomer(string name, string phoneNumber, string egn)
            : base(name, phoneNumber)
        {
            this.egn = egn;
        }

        // Properties
        public string EGN
        {
            get { return this.egn; }
            set { this.egn = value; }
        }
    }
}
