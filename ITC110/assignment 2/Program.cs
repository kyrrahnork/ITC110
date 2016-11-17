using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    /* This program will take in two integers 
        and ouput the sum, the difference
        and the product.
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
            int ans1 = a + b;
            int ans2 = a - b;
            int ans3 = a * b;
            Console.WriteLine("The sum of {0} and {1} is {2}.", a, b, ans1);
            Console.WriteLine("The difference of {0} and {1} is {2}.", a, b, ans2);
            Console.WriteLine("The product of {0} and {1} is {2}.", a, b, ans3);
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
