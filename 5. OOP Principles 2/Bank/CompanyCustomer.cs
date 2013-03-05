using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class CompanyCustomer : Customer
    {
        // Fields
        private string acountantName;

        // Constructor
        public CompanyCustomer()
            : this(string.Empty, string.Empty) { }

        public CompanyCustomer(string name, string phoneNumber)
            : this(name, phoneNumber, string.Empty) { }

        public CompanyCustomer(string name, string phoneNumber, string acountantName)
            : base(name, phoneNumber) 
        {
            this.acountantName = acountantName;
        }

        //Properties
        public string AcountantName
        {
            get { return this.acountantName; }
            set { this.acountantName = value; }
        }
    }
}
