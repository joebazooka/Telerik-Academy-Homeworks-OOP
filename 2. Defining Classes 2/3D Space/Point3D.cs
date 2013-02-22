using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Space
{
    struct Point3D
    {
        private static Point3D o = new Point3D(0, 0, 0);

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D O
        {
            get
            {
                return o;
            }
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}
