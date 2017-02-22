using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* This program calculates the price of the phone call depending if the call made
  outside its area code or inside or both*/
namespace Lab6_Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            //veriables
            int areaCode, calledArea;
            double callTime;
            double pricePerCall;
            const double pricePerMin = .13;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //input
            Console.Write("Please enter your area code: ");
            areaCode = int.Parse(Console.ReadLine());

            Console.Write("Please enter erea code you called: ");
            calledArea = int.Parse(Console.ReadLine());

            Console.Write("Please enter call time in minutes: ");
            callTime = double.Parse(Console.ReadLine());

            //processes
            if (areaCode != calledArea && callTime > 20)
            {
                pricePerCall = 20 * pricePerMin + ((callTime - 20) * .1);
                 
            }
            else
            {
                pricePerCall = callTime * pricePerMin;
            }

            //output
            Console.WriteLine("=============================================");
            Console.WriteLine("Your calling area is: {0}", areaCode);
            Console.WriteLine("Your called area code is: {0}", calledArea);
            Console.WriteLine("Total price of the call is: {0}", pricePerCall.ToString("c2"));
        }
    }
}
