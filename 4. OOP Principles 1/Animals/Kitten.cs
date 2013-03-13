using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Cat
    {
        // Constructors
        public Kitten(string name, int age)
            : base(name, age, 'f') { }

        // Properties
        public char Sex
        {
            get { return 'f'; }
            private set 
            {
                this.Sex = 'f';
            }
        }

        // Methods
        public override void ProduceSound()
        {
            Console.WriteLine("Mew Mew");
        }
    }
}
