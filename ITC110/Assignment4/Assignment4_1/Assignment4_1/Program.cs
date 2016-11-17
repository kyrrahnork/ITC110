using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This program will create a for loop that displays 10 random numbers between 1 and 500.*/
 
namespace NorkAssignment4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are the 10 random numbers between 1 and 500 that you requested.");

            Random rand = new Random();

            for (int i = 0; i < 11; i++)
            {
                int num = rand.Next(1, 501);
                Console.WriteLine(num);
            }
            Console.WriteLine("Please press any key to exit.");
            Console.ReadKey();
        }
    }
}
