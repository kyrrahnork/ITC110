using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorkAssignment6
{
    class Program
    {
        /*Create a program that calculates a grade point average divided into the following methods:
            A method to take the input from the user
            A method that calculates the GPA and returns a double
            A display method that calls the input method, and the Calculation and displays the result.
            The Main method which starts the program and calls the display method
        */
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Display();
        }

        private void Display()
        {
            GetInput();
            
        }



        private void GetInput()
        {
            Console.WriteLine("How many grades would you like to enter?");
            int input = 0;
            bool good = false;

            while (!good)
            {
                good = int.TryParse(Console.ReadLine(), out input);
                if (!good)
                    Console.WriteLine("Please enter a valid integer.");
            }
            double[] grades = GetGrades(input);
            double[] credits = GetCredits(input);
            Info(grades, credits);
        }

        private double[] GetGrades(int input)
        {
            //put input into arrays
            double[] grades = new double[input];
            
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("please enter grade number {0}.", (i + 1));
                double grade = 0;
                bool good1 = false;

                while (!good1)
                {
                    good1 = double.TryParse(Console.ReadLine(), out grade);
                    if (!good1)
                        Console.WriteLine("Please enter a valid grade.");
                }
                grades[i] = grade;
            }
            return grades;
        }

        private double[] GetCredits(int input)
        {
            double[] credits = new double[input];

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Please enter the number of credits for grade number {0}", (i + 1));
                double credit = 0;
                bool good2 = false;

                while (!good2)
                {
                    good2 = double.TryParse(Console.ReadLine(), out credit);
                    if (!good2)
                        Console.WriteLine("Please enter a valid number of credits.");
                }
                credits[i] = credit;
            }
            return credits;
        }
               
            

        private void Info(double[] grades, double[] credits)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Grade: " + grades[i] + " Credits: " + credits[i]);
            }
            double gpa = CalculateGpa(grades, credits);
            Console.WriteLine("The overall GPA is {0:0.00}", gpa);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private double CalculateGpa(double[] grades, double[] credits)
        {
            double weight = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                weight = weight + grades[i] * credits[i];
            }

            double creditsTotal = 0;
            for (int i = 0; i < credits.Length; i++)
            {
                creditsTotal = creditsTotal + credits[i];
            }

            double gpa = weight / creditsTotal;
            return gpa;
        }
    }
}


