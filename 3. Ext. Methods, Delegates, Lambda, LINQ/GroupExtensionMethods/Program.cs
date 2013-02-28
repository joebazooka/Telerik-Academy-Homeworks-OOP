using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Sum: " + test.Sum());
            Console.WriteLine("Product: " + test.Product());
            Console.WriteLine("Max: " + test.Max());
            Console.WriteLine("Min: " + test.Min());
            Console.WriteLine("Average: " + test.Average());
        }
    }
}
