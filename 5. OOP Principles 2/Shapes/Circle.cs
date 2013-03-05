using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        // Fields
        private double radius;

        // Constructors
        public Circle()
            : this(0) { }

        public Circle(double radius)
            : base(2 * radius, 2 * radius) 
        {
            this.radius = radius;
        }

        // Methods
        public override double CalculateSurface()
        {
            return Math.PI * radius * radius;
        }
    }
}
