using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This program will count down (and displays the count) from 10 to 0 */
namespace NorkAssignment4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 10; i > -1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Please press any key to exit");
            Console.ReadKey();
        }
    }
}
