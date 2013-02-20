using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Display
    {
        // Fields
        private int? width;
        private int? height;
        private long? numColors;

        // Constructors
        public Display()
        {
            this.width = null;
            this.height = null;
            this.numColors = null;
        }

        public Display(int width, int height)
            : this(width, height, null)
        {
            this.width = width;
            this.height = height;
        }

        public Display(int width, int height, long? numColors)
        {
            this.width = width;
            this.height = height;
            this.numColors = numColors;
        }

        // Properties
        public int? Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.width = value;
            }
        }

        public int? Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.height = value;
            }
        }

        public long? NumColors
        {
            get { return this.numColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.numColors = value;
            }
        }

        // Methods

        // ToString Method
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.width != null && this.height != null)
            {
                result.AppendFormat("\n\tSize: {0}x{1}", this.width, this.height);
            }
            if (this.numColors != null)
            {
                result.AppendFormat("\n\tNumber of Colors: {0}", this.numColors);
            }

            return result.ToString();
        }
    }
}
