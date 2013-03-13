using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    [Version("2.11.")]
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Program);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in attributes)
            {
                Console.WriteLine("Version: {0}", attr);
            }
        }
    }
}
