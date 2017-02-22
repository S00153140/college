using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_CAO_Points
    /* @ author Karolis Gunka
     * @ 05/12/2016
     * This program calculates CAO leaving cert points 
     * for 2017
     * it allows user to enter 6 subjects
     * it calculates total points and average points per subject. */
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables
            int i;                              //For looping variables
            string choice = "y";                //Restarting variable

            string[] lcSubjects = new string[6]; //creating array that holds 6 subjects
            string[] lcGrades = new string[6]; // array that holds 6 grades
            int[] lcPoints = new int[6]; //and array that holds 6 points

            int total = 0, average = 0;
            string inputFormatTable = "{0,-5}{1,-2}{2,-5}", outputFormatTable = "{0,-10}{1,-10}{2,-4}"; //input/output format tables
            const int Extra_Maths_Points = 25;

            while (choice == "y" || choice == "Y") //loop for choice ether restart the loop or end  it
            {
                Console.Clear();
                Array.Clear(lcGrades, 0, 6);
                Array.Clear(lcPoints, 0, 6);
                Array.Clear(lcSubjects, 0, 6);
                total = 0; average = 0; //specifing total and average to be  0 each time loop runs
                for (i = 0; i < 6; i++)
                {
                    //Input
                    Console.WriteLine();
                    Console.Write(inputFormatTable, " Enter Subject ", i + 1, ":"); //user enters subject and stores in i variable
                    lcSubjects[i] = Console.ReadLine();
                    Console.Write(inputFormatTable, "   Enter grade ", i + 1, ":");
                    lcGrades[i] = Console.ReadLine().ToUpper(); //places input of the grades in capital letters 

                    //Processing
                    switch (lcGrades[i])
                    {
                        case "H1":
                            lcPoints[i] = 100; // looks for the case and when it finds assigns points to it
                            break;
                        case "H2":
                            lcPoints[i] = 88;
                            break;
                        case "H3":
                            lcPoints[i] = 77;
                            break;
                        case "H4":
                            lcPoints[i] = 66;
                            break;
                        case "H5":
                        case "O1":
                            lcPoints[i] = 56;
                            break;
                        case "H6":
                        case "O2":
                            lcPoints[i] = 46;
                            break;
                        case "H7":
                        case "O3":
                            lcPoints[i] = 37;
                            break;
                        case "H8":
                            lcPoints[i] = 0;
                            break;
                        case "O4":
                            lcPoints[i] = 28;
                            break;
                        case "O5":
                            lcPoints[i] = 20;
                            break;
                        case "O6":
                            lcPoints[i] = 12;
                            break;
                        case "O7":
                            lcPoints[1] = 0;
                            break;
                        case "O8":
                            lcPoints[i] = 0;
                            break;
                        default:

                            Console.WriteLine("Wrong value!");
                            break;
                    }

                    if (lcSubjects[i].ToUpper() == "MATHS" && lcGrades[i].Contains("H") && (lcGrades[i] != "H7" || lcGrades[i] != "H8"))
                    {
                        lcPoints[i] += Extra_Maths_Points; //if subject contains maths and grade is higher than h7 and h8 it adds 25 to the total 
                    }
                    total += lcPoints[i]; //adds points to total
                    average = total / 6; // gets average by deviding total into 6
                    
                }

                Console.Clear(); 

                Console.WriteLine("Grade Report");
                Console.WriteLine();
                Console.WriteLine(outputFormatTable, "Subject", "Grades", "Points");
                Console.WriteLine();

                for (i = 0; i < 6; i++)
                {
                    if (lcSubjects[i].ToUpper() == "MATHS" && lcGrades[i].Contains("H") && (lcGrades[i] != "H7" || lcGrades[i] != "H8"))
                    {
                        Console.WriteLine(outputFormatTable + "{3,-5}", lcSubjects[i], lcGrades[i], lcPoints[i], "+");// if it is higher level maths and the grade is bigger than h7 and h8 it will add + symbol in the output
                    }
                    else
                    {
                        Console.WriteLine(outputFormatTable, lcSubjects[i], lcGrades[i], lcPoints[i]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("  Total Points: " + total.ToString("000"));
                Console.WriteLine("Average Points: " + average.ToString("000"));
                Console.WriteLine();
                Console.WriteLine("+ includes 25 bonus points");
                Console.WriteLine();
                Console.WriteLine("Would you like to calculate again? (y/n) : ");
                choice = Console.ReadLine(); //waits for user input to ether restart the code or end it
            }
        }
    }
}
