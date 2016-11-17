

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NorkAssignment5_1
{
    class Program
    {
        /* This program will create an array of 50 random numbers
        * between 1 and 250 and output a count of how many of the
        * array elements are even numbers.
        */
        static void Main(string[] args)
        {

            int[] randomNum = new int[50];


            Random rand = new Random();


            for (int i = 0; i < 50; i++)
            {
                randomNum[i] = rand.Next(1, 251);
            }
            Console.WriteLine("You have created an array of 50 random numbers, they are:");
            //randomNum.ToList().ForEach(Console.WriteLine);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(randomNum[i]);
            }

            int even = 0;
            foreach (int i in randomNum)
            {
                if (i % 2 == 0)
                    even++;
            }

            Console.WriteLine("There are {0} even numbers in this array", even);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}