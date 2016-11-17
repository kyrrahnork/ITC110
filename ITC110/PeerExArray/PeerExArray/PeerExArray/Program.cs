using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorkPeerExArray
{
    class Program
    {
        /* This program will create an array of 20 random numbers
        * between 1 and 250 and output the highest and the lowest numbers.
        */
        static void Main(string[] args)
        {
            

            int[] randomNum = new int[20];

            Random rand = new Random();


            for (int i = 0; i < 20; i++)
            {
               randomNum[i] = rand.Next(1, 251);
            }
            Console.WriteLine("You have created an array of 20 random numbers, they are:");
            //randomNum.ToList().ForEach(Console.WriteLine);
            for (int i = 0; i <20; i++)
            {
                Console.WriteLine(randomNum[i]);
            }
            Console.WriteLine("The highest random number is: {0}", randomNum.Max());
            Console.WriteLine("The lowest random number is: {0}", randomNum.Min());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
