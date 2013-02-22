using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Space
{
    class Path
    {
        private List<Point3D> path;

        public List<Point3D> ThePath
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }

        public int Count
        {
            get
            {
                return path.Count;
            }
        }

        public Path()
        {
            path = new List<Point3D>();
        }

        public Path(List<Point3D> path)
            : this()
        {
            this.path = path;
        }

        public void AddPoint(Point3D point)
        {
            this.path.Add(point);
        }

        public void ClearPath()
        {
            this.path.Clear();
        }
    }
}
