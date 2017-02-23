using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceAssigment
{/*************************************
    *this program calculates the premium*
    *for the customer and give a quote*
    *************************************/

    class Program
    {
        static double premiumQuote; //veriable that can be used by all the methods
        static void Main(string[] args)

           
        {
            int vehicleValue, age, penaltyPoints;
            string gender;

            Console.OutputEncoding = Encoding.UTF8; //for euro sign to appear

            
            do
            {
                Console.Clear();
                vehicleValue = getInt("Enter Vehicle value: ");

                if (vehicleValue == -999) //if -999 is entered it will end  the loop
                    continue;

                
                age = getInt("Enter your age: "); //calling method to convert and read int 
                gender = getGender();

                penaltyPoints = getInt("Enter penelty points: ");

                if (age >= 16 && age < 120) //if age is obove 16 and below 120 applies the premium
                {
                    premiumQuote = vehicleValue * 0.03;
                    premiumQuote = getIncrease(gender, age);
                    premiumQuote = penaltyPointsInrease(penaltyPoints); //gets premium if there is penalty points


                }

                if (premiumQuote == 0) // no points no premium
                {
                    Console.WriteLine("Quote is not available!");
                }
                else
                {
                    Console.WriteLine("Your Quote is: {0:c}", premiumQuote);
                }

                Console.ReadLine(); // read input on keyboard to restart the loop





            } while (vehicleValue != -999); //if sentinental value entered loop ends
        }

        static  string getGender()
        {
            bool inputCorrect = false;
            string result = "";

            while (inputCorrect == false)
            {
                Console.Write("Enter Gender (male/female): ");
                result = Console.ReadLine().Trim().ToLower();

                if (result == "male" || result == "female") //check if input is true or false for male or female

                    inputCorrect = true;

                else

                    continue;
               }
            return result; //sends result back
        }
        
        static int getInt(string prompt) //when you call it will read as an integer
        {
            int result;
            Console.Write(prompt);
            result = int.Parse(Console.ReadLine());
            return result;
            
        }

        static double getIncrease(string gender, int age) //gets premium if certain conditions apply
        {
            if (gender == "male" || age < 25 )
            {
                premiumQuote *= 1.1; 
            }
            else if(gender == "female" || age < 21)
            {
                premiumQuote *= 1.06;
            }
            return premiumQuote;
        }

        static double penaltyPointsInrease(int penaltyPoints) //calculates additional premium charge if costumer have points
        {
            switch(penaltyPoints)
            {
                case 0:
                    Console.WriteLine("No extra charge!");
                    break;
                case 1: case 2: case 3: case 4:
                    premiumQuote += 100;
                    break;
                case 5: case 6: case 7:
                    premiumQuote += 200;
                    break;
                case 8: case 9: case 10:
                    premiumQuote += 300;
                    break;
                case 11: case 12:
                    premiumQuote += 400;
                    break;

                default:
                    Console.WriteLine("No Quote Possible!");
                    break;

                        

            }
            return premiumQuote;
        }

        
        
            
        
    }
}
