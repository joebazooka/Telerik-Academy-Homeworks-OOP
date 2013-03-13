using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Student : Human
    {
        // Fields
        private int grade;

        // Constructors
        public Student()
            : this(string.Empty, string.Empty, 0) { }

        public Student(string firstName, string lastName)
            : this(firstName, lastName, 0) { }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        // Properties
        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        // Methods
        public override string ToString()
        {
            return String.Format("{0} Grade: {1}", base.ToString(), this.grade);
        }
    }
}
