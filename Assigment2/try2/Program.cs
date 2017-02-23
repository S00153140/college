using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try2
{
    /*******************************
     this program calculates the cost of the fine 
     if the customer brings dvd late depending of the dvd value,
     age of the customer and no. of days late
     *********************************************/
    class Program
    {
        static double fine;// veriable can be used by all methods
        static void Main(string[] args)
        {
            //ver
            int daysLate, age;
            double retailValue;
            string dvdType;

            Console.OutputEncoding = Encoding.UTF8;

            do
            {
                Console.Clear();
                //input
                daysLate = getInt("Enter days(enter -999 to quit): ");

                if (daysLate == -999)
                    continue;


                Console.Write("Enter DVD type: ");
                dvdType = Console.ReadLine().Trim().ToLower();

                retailValue = getDouble("Enter dvd retail value: ");
                age = getInt("Enter members age: ");
                //process
                fine = dayFee(daysLate, age, retailValue, dvdType);

                //output
                Console.WriteLine("Your fine is: {0:c}", fine);

                Console.ReadLine();


            }

            while (daysLate != -999);
        }

        static int getInt(string prompt)
        {
            int result;
            Console.Write(prompt);
            result = int.Parse(Console.ReadLine());

            return result;
            
        }

        static double getDouble(string prompt)
        {
            double result;
            Console.Write(prompt);
            result = double.Parse(Console.ReadLine());

            return result;

        }

        static double dayFee(int daysLate, int age, double retailValue, string dvdType)
        {
            switch(daysLate)
            {
                case 0:
                    fine = 0;
                    break;
                case 1: case 2: case 3: case 4:
                    fine = daysLate * 0.5;
                    break;
                case 5: case 6: case 7:
                    fine = daysLate * 0.75;
                    break;
                case 8: case 9: case 10:
                    fine = daysLate * 1.00;
                    break;
                case 11: case 12: case 13: case 14: case 15:
                    fine = daysLate * 2.00;
                    break;
                default:
                    fine = daysLate * 2.50;
                    break;
            }


            fine = extraCharge(age, retailValue, dvdType);
            return fine;
        }

        static double extraCharge(int age, double retailValue, string dvdType)
        {
            if (dvdType == "new release")
            {
                if (age < 18)
                {
                    fine += (retailValue * .1);

                }
                else
                {
                    fine += (retailValue * .12);

                }
            }

            else if (dvdType == "old release")
            {
                if (age < 18)
                {
                    fine += (retailValue * .05); 
                }
                else
                {
                    fine += (retailValue * 0.07);
                }

            }
            return fine;

            }
           

            
        



        
    }
}
