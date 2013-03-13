using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    abstract class Human
    {
        // Fields
        private string firstName;
        private string lastName;

        // Constructors
        public Human()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        // Methods
        public override string ToString()
        {
            return String.Format("{0} {1}", this.firstName, this.lastName);
        }
    }
}
