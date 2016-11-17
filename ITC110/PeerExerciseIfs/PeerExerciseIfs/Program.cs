using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Have the user enter their user name and password. If the username is customer
 * and the password is P@ssw0rd1, return a message that says "Thank you for logging in."
 * Otherwise return "Invalid user or password."
*/

namespace NorkPeerExerciseIfs
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter your user name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your user password");
            string pass = Console.ReadLine();

            if (name.Equals("customer") && pass.Equals("P@ssw0rd"))
            {
                Console.WriteLine("Thank you for logging in.");
            }
            else
            {
                Console.WriteLine("Invalid user or password.");
            }

            Console.ReadKey();
        }
    }
}
