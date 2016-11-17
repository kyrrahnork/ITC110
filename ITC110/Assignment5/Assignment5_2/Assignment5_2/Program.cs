

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NorkAssignment5_2
{
    class Program
    {
        /* This program will create an array of strings
         * and use a random number generator
         * to randomly select and display one of the quotes
         * from the array every time the program is run.
        */
        static void Main(string[] args)
        {

            string[] quotes = {"May the force be with you!", "These are not the droids you are looking for!",
                                "Judge me by my size, do you","The force is strong with this one.",
                                "Do or do not. There is no try.", "Aren't you a little short for a stormtrooper?",
                                "I find your lack of faith disturbing.", "That's no moon, thats a space station!",
                                "I am your father Luke.", "In my experience there is no such thing as luck."};

            //below is an alternative way to put the strings in the array

            //quotes[0] = "May the force be with you!";
            //quotes[1] = "These are not the droids you are looking for!";
            //quotes[2] = "Judge me by my size, do you";
            //quotes[3] = "The force is strong with this one.";
            //quotes[4] = "Do or do not. There is no try.";
            //quotes[5] = "Aren't you a little short for a stormtrooper?";
            //quotes[6] = "I find your lack of faith disturbing.";
            //quotes[7] = "That's no moon, thats a space station!";
            //quotes[8] = "I am your father Luke.";
            //quotes[9] = "In my experience there is no such thing as luck.";

            Random RandString = new Random();
            string quote = quotes[RandString.Next(0, quotes.Length - 1)];


            Console.WriteLine(quote);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}


