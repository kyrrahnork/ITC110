using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peerWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //start of while loop
            {
                Console.WriteLine("Please select between options 1, 2, or 3");  //ask for input
                Console.WriteLine("Please make your selection:");
                Char input = Console.ReadKey().KeyChar;  //read the input
                Console.WriteLine();  //write choice
                switch (input)  //start switch cases
                {
                    case '1':
                        Console.WriteLine("You have selected option 1");
                        break;
                    case '2':
                        Console.WriteLine("You have selected option 2");
                        break;
                    case '3':
                        Console.WriteLine("Goodbye (Please hit any key to exit.)");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("You have entered an invalid choice."); 
                        break;
                }
            }
        }
    }
}
