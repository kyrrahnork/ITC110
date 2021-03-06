﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorkSlorahPeerExMethods
{
    class Program
    {
        /* This program is broken into methods and the main
        * does nothing but call the starting method
        */
        static void Main(string[] args)
        {
            //initialize class to access methods

            Program p = new Program();
            p.GetInput();
        }

        private void GetInput()
        {

            int number = 0;
            Console.WriteLine("Please enter an integer between 1 and 41");
            bool isInt = int.TryParse(Console.ReadLine(), out number);
            if (!isInt)
            {
                Console.WriteLine("Please enter a valid integer");
                Console.ReadKey();
                return;
            }
            if (number < 1 || number > 41)
            {
                Console.WriteLine
                  ("Please enter a valid integer between 1 and 41");
                Console.ReadKey();
                return;
            }
            int prime = Calc(number);
            Output(prime);
        }


        private int Calc(int number)
        {
            int prime = number * number - number + 41;
            return prime;
        }


        private void Output(int prime)
        {
            Console.WriteLine("The prime number is {0}", prime);
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }
    }
}
