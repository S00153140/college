using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    class Program
    {
        static double fine;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int daysLate, age;
            double retailValue;
            string dvdType; 

            do
            {
                Console.Clear();
                daysLate = getIn("Enter days Late (-999 to exit): ");

                if (daysLate == -999)
                    continue; 

                retailValue = getDouble("Enter dvd retail value: ");

                age = getIn("Enter members age: ");

                Console.Write("Enter DVD type: " );
                dvdType = Console.ReadLine().Trim().ToLower();

                fine = addCharge(daysLate, age, dvdType, retailValue);

                Console.WriteLine("Your fine is: {0:c}", fine);
                Console.ReadLine();
                 
            } while (daysLate != -999);
        }

        static int getIn(string prompt)
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

        static double addCharge(int daysLate, int age, string dvdType, double retailValue)
        {
            double extra;
            switch(daysLate)
            {
                case 0:
                    fine = 0;
                    break;
                case 1: case 2: case 3: case 4:
                    fine = daysLate* 0.5;
                    break;
                case 5: case 6: case 7:
                    fine = daysLate* 0.75;
                    break;
                case 8: case 9: case 10:
                    fine =daysLate* 1.00;
                    break;
                case 11: case 12: case 13: case 14: case 15:
                    fine =daysLate* 2.00;
                    break;
                default:
                    fine =daysLate* 2.50;
                    break;

                    

            }
            fine = extraFees(age, dvdType, retailValue);
             
            return fine;
        }

        static double extraFees(int age, string dvdType, double retailValue)
        {

            if (dvdType == "new release")
            {
                if (age < 18)
                    fine *= 1.1;
            }

            else if (dvdType == "old release")
            {
                if (age < 18)
                    fine *= 1.05;
            }

            if (dvdType == "new release")
            {
                if (age >= 18)
                    fine *= 1.12;
            }

            else if (dvdType == "old release")
            {
                if (age >= 18)
                    fine *= 1.07;
            }

            if (fine >= retailValue)
            {
                fine = retailValue;
            }

            return fine;


        }
        
    }
}
