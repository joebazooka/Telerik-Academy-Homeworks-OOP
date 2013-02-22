using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _3D_Space
{
    class Program
    {
        /*
         *      Test file.
         * 
                ../../PathSave.txt
         */

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            // Create Path
            Path path = new Path();

            // Fill path with points
            path.AddPoint(Point3D.O);
            path.AddPoint(new Point3D(2, 4, 6));
            path.AddPoint(new Point3D(1, -2, 8));
            path.AddPoint(new Point3D(2.2, 4.0, 16));
            path.AddPoint(new Point3D(45, 8, 0.0));
            path.AddPoint(new Point3D(0, 3.5, 5));
            path.AddPoint(new Point3D(3, 45, 6.5445));

            // Print count and contents of path
            Console.WriteLine("Count: {0}", path.Count);

            foreach (Point3D point in path.ThePath)
            {
                Console.WriteLine(point.ToString());
            }

            // Test Saving
            PathStorage.SavePath(path);

            // Test Clearing
            path.ClearPath();

            Console.WriteLine("Count: {0}", path.Count);

            // Test Loading
            path = PathStorage.LoadPath();

            Console.WriteLine("Count: {0}", path.Count);

            foreach (Point3D point in path.ThePath)
            {
                Console.WriteLine(point.ToString());
            }

            // Test distance between points
            Point3D point1 = new Point3D(4,8,3);
            Point3D point2 = new Point3D(6,3,10);

            Console.WriteLine("Distance between {0} and {1}: {2}", 
                point1.ToString(), point2.ToString(), Distance3D.Distance(point1, point2));

            /*
             * Expected result: 8.83176086632785
             */
        }
    }
}
