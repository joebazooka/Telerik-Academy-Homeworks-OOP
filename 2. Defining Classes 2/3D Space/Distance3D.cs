using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Space
{
    static class Distance3D
    {
        public static double Distance(Point3D start, Point3D end)
        {
            double distance = Math.Sqrt((start.X - end.X) * (start.X - end.X) +
                                        (start.Y - end.Y) * (start.Y - end.Y) +
                                        (start.Z - end.Z) * (start.Z - end.Z));

            return distance;
        }
    }
}
