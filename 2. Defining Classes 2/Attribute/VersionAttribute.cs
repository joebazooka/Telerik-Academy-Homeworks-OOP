using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    [AttributeUsage(
        AttributeTargets.Struct | 
        AttributeTargets.Class | 
        AttributeTargets.Interface | 
        AttributeTargets.Enum | 
        AttributeTargets.Method)]
    class VersionAttribute : System.Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(string version)
        {
            try
            {
                string[] split = version.Split('.');

                this.Major = int.Parse(split[0]);
                this.Minor = int.Parse(split[1]);
            }
            catch (Exception)
            {
                throw new ArgumentException("Incorrect format of version. Use \"major.minor\".");
            }
        }

        public override string ToString()
        {
            return this.Major + "." + this.Minor;
        }
    }
}
