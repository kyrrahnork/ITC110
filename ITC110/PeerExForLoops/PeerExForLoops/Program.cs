using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  This program will display all the odd numbers between 1-100
	grouped into lines of 5 numbers.
*/

namespace AssignmentPeerExForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
                else if (i % 10 == 0)
                    Console.WriteLine(" ");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}