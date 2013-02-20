using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM phone1 = new GSM("3110", "Nokia");
            GSM phone2 = new GSM("Galaxy S III", "Samsung", 939.0);
            GSM phone3 = new GSM("E52", "Nokia", 200.0, "Me",
                new Battery("BP-4L", BatteryType.LiIon, 672, 8), new Display(240, 320));

            // Zad 7
            GSM[] phones = new GSM[] { phone1, phone2, phone3 };

            foreach (GSM phone in phones)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine(GSM.IPhone4S);

            // Zad 12
            //phone1.AddCall(new Call("123", 50));
            //phone1.AddCall(new Call(new DateTime(2013, 2, 21, 15, 30, 25), "123", 30));
            //phone1.AddCall(new Call("123", 69));
            //phone1.AddCall(new Call("123", 189));
            //phone1.AddCall(new Call("123", 245));

            //Console.WriteLine("Call Info");
            //Console.WriteLine(phone1.CallHistoryInfo());

            //double pricePerMinute = 0.37;
            //Console.WriteLine("Price per Minute: {0:C}", pricePerMinute);
            //Console.WriteLine("Total price to pay: {0:C}", phone1.TotalPrice(pricePerMinute));

            //phone1.DeleteLongestCall();

            //Console.WriteLine("Price per Minute: {0:C}", pricePerMinute);
            //Console.WriteLine("Total price to pay: {0:C}", phone1.TotalPrice(pricePerMinute));

            //phone1.ClearCallHistory();
        }
    }
}
