using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    /* Take in two integers and ouput
     the quotient (division) and the remainder, if any (modulus).
    */
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetValue();
        }
        private void GetValue()
        {
            Console.WriteLine("Enter your first integer"); //ask for first number
            int a = int.Parse(Console.ReadLine()); //parse as a number
            Console.WriteLine("Enter your second integer"); //ask for second number
            int b = int.Parse(Console.ReadLine()); //parse as a number
            int ans1 = a / b; //divide the first number by the second number
            int ans2 = a % b; //find the remainder
            Console.WriteLine("The quotient of {0} and {1} is {2} with a remainder of {3}", a, b, ans1, ans2);
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
