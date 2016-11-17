using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorkAssignment4_4
{
    class Program
    {
        /*This program will create a do loop that runs until a user enters "stop."*/
        static void Main(string[] args)
        {
            String choice = "yes";
            int counter = 0;

            do
            {
                counter++;
                Console.WriteLine(counter);
                Console.WriteLine("Would you like to continue? Please type 'stop' to quit and exit, any other entry will allow you to continue.");
                choice = Console.ReadLine();
                choice = choice.ToLower();
            }while (!choice.Equals("stop"));
        }
    }
}
