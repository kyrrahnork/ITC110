using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Have the user enter a number. If it is even output
"Even," if odd, "Odd."
*/

namespace NorkAssignment3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetValue();
        }
        private void GetValue()
        {
            Console.WriteLine("Please enter any number."); //ask for number
            double num = double.Parse(Console.ReadLine()); //parse as a number

            if (num % 2 == 0)
            {
                Console.WriteLine("The number you entered is EVEN!");
            }
            else
            {
                Console.WriteLine("The number you entered is ODD!");
            }

            Console.WriteLine("Press any key to end");
            Console.ReadKey();

        }
    }
}