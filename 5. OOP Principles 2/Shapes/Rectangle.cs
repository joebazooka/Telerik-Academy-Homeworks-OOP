using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        // Constructor
        public Rectangle()
            : this(0, 0) { }

        public Rectangle(double width, double height)
            : base(width, height) { }

        // Methods
        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
