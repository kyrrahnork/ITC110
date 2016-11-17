using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorkAssignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            p.Intro();
            p.Evaluate(p.RandomNumber());

        }

        private int RandomNumber()
        {
            Random rand = new Random();
            int ran = rand.Next(1, 501);
            Console.WriteLine(ran);
            return ran;
        }

        private void Intro()
        {

            Console.WriteLine("In this game you will have to guess a random number between 1-500.");
            Console.WriteLine("You will be given 10 guesses. You will be told whether your guess is:");
            Console.WriteLine();
            Console.WriteLine("Too High");
            Console.WriteLine("Too Low");
            Console.WriteLine("or Correct");
            Console.WriteLine();
            Console.WriteLine("Press any key to begin");
            Console.ReadKey();
        }

        private int GuessLoop()
        {

            int numberGuessed = 0;
            bool good = false;

            Console.WriteLine("What is your guess.");

            while (!good)
            {
                good = int.TryParse(Console.ReadLine(), out numberGuessed);
                if (numberGuessed < 1 || numberGuessed > 500 || !good)
                    Console.WriteLine("Please enter a valid integer.");
            }

            return numberGuessed;
        }

        private void Evaluate(int a)
        {
            int count = 1;
            while (count < 10)
            {
                int b = GuessLoop();
                if (b < a)
                {
                    Console.WriteLine("Too low.");
                    Console.WriteLine("Next guess.");
                    
                    count++;

                }
                else if (b > a)
                {
                    Console.WriteLine("Too high.");
                    Console.WriteLine("Next guess.");
                    
                    count++;
                }
                else
                {
                    
                    Console.WriteLine("You got it!");
                    Console.WriteLine("Your score is {0} out of 10", (10 - count + 1));
                    Console.WriteLine("Press any key to end the game.");
                    Console.ReadKey();
                    Console.WriteLine("Would you like to play again?");
                    Restart();
                    break;              
                }
            }
        }

        private void Restart()
        {
            int x = 0;
            bool good = false;
            Console.WriteLine("Press 1 for yes or 2 for no.");
            while (!good)
            {
                good = int.TryParse(Console.ReadLine(), out x);
                    if (x == 1)
                    {
                        Console.WriteLine("Press any key to begin the next game.");
                        Console.ReadKey();
                    }
                    if (x == 2)
                    {
                        Console.WriteLine("Thank you for playing.");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                        break;
                }
                else
                {
                    Console.WriteLine("Please enter 1 or 2.");
                }
            }

            Intro();
                
        }
    }
}




            

