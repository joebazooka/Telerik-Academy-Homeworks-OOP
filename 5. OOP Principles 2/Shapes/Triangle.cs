using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        // Constructor
        public Triangle()
            : this(0, 0) { }

        public Triangle(double width, double height)
            : base(width, height) { }

        // Methods
        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
