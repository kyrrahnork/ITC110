using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopPractice
{

    class Program
    {
        /* this program will explore repetition with
         * for loops.
         *Kyrrah Nork 10/18/2016
         */
        static void Main(string[] args)
        {
            int number = 0;
            long number2 = 0;
            Console.WriteLine("how many times do you want to loop?");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number you want to stary squaring");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= number; i++)
            {
                number2 *= number2;
                Console.WriteLine(number2);
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
