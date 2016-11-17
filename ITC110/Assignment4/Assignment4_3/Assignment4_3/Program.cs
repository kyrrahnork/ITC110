using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorkAssignment4_3
{
    class Program
    {
        /* This program will Create a while loop that displays the count
         * of the loops and then asks the user whether they want to continue
         * or not. If yes, then continue; if no the program should end and
         * display a note saying thank you
         */
        static void Main(string[] args)
        {
            string choice = "yes";
            int counter = 0;

            while (choice.Equals("yes"))
            {
                counter++;
                Console.WriteLine(counter);
                Console.WriteLine("Enter 'yes' to continue, or 'no' to stop and exit.");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Thank you!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
