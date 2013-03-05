using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        // Fields
        private double height;
        private double width;

        // Constructor
        public Shape()
            : this(0, 0) { }

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Properties
        public double Height
        {
            get { return this.height; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.height = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.width = value;
            }
        }

        // Methods
        public abstract double CalculateSurface();
    }
}
