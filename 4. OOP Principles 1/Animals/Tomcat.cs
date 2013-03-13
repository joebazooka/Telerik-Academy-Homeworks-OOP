using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat : Cat
    {
        // Constructors
        public Tomcat(string name, int age)
            : base(name, age, 'm') { }

        // Properties
        public char Sex
        {
            get { return 'm'; }
            private set
            {
                this.Sex = 'm';
            }
        }

        // Methods
        public override void ProduceSound()
        {
            Console.WriteLine("Hisssss");
        }
    }
}
