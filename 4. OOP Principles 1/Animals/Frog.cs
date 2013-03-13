using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal
    {
        // Constructors
        public Frog(string name, int age, char sex)
            : base(name, age, sex) { }

        // Methods
        public override void ProduceSound()
        {
            Console.WriteLine("Croak Croak");
        }
    }
}
