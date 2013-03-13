using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            InvalidRangeException<int> intException =
                new InvalidRangeException<int>("Incorect. Enter a valid integer number.", 1, 100);

            InvalidRangeException<DateTime> dateException = 
                new InvalidRangeException<DateTime>("Incorect. Enter a valid date.", 
                    new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));

            Console.WriteLine("Enter a number.");
            try
            {
                int num = int.Parse(Console.ReadLine());

                if (num < intException.Start || num > intException.End)
                {
                    throw intException;
                }
                else
                {
                    Console.WriteLine("Correct number.");
                }

                DateTime date = new DateTime(2014, 1, 1);

                Console.WriteLine("Date to check: {0}", date);

                if (date < dateException.Start || date > dateException.End)
                {
                    throw dateException;
                }
                else
                {
                    Console.WriteLine("Correct date.");
                }
            }
            catch (InvalidRangeException<int> ire)
            {
                Console.WriteLine(ire.Message);
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine(ire.Message);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
        }
    }
}
