using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTimerEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(10);
            timer.Methods = TestMethod1;
            timer.Methods += TestMethod2;

            Subscriber sub = new Subscriber("Test", timer);

            timer.Execute();
        }

        public static void TestMethod1()
        {
            Console.WriteLine("Test 1 (Called at: {0:HH:mm:ss})", DateTime.Now);
        }

        public static void TestMethod2()
        {
            Console.WriteLine("Test 2 (Called at: {0:HH:mm:ss})", DateTime.Now);
        }
    }
}
