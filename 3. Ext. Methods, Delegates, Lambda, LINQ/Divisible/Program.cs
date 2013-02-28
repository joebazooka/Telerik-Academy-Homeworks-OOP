using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 121, 173, 354, 89, 7, 289, 424, 21, 124, 154, 249, 66, 196, 435, 324, 63, 241, 3, 127, 64, 42, 242, 141, 288 };

            // With Lambda

            int[] result = numbers.Where(num => num % 3 == 0 && num % 7 == 0).Select(num => num).ToArray();

            // With LINQ
            /*
            int[] result =
                (from num in numbers
                where num % 3 == 0 && num % 7 == 0
                select num).ToArray();
            */
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
