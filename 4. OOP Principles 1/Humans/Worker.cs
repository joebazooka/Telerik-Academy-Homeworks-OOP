using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Worker : Human
    {
        // Fields
        private double weekSalary;
        private double workHoursPerDay;

        // Constructors
        public Worker()
            : this(string.Empty, string.Empty, 0, 0) { }

        public Worker(string firstName, string lastName)
            : this(firstName, lastName, 0, 0) { }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        // Properties
        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        // Methods
        public double MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay * 5.0;
        }

        public override string ToString()
        {
            return String.Format("{0} Money per hour: {1:C}", base.ToString(), this.MoneyPerHour());
        }
    }
}
