using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Have the user enter a grade point between 0 and 4.
Validate that the number is in the correct range then
evaluate the number to assign a letter grade
*/
namespace NorkAssignment3_3
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
            Console.WriteLine("Please enter a grade point between 0 and 4."); //ask for number
            double num = double.Parse(Console.ReadLine()); //parse as a number
            if (num > 4 || num < 0)
            {
                Console.WriteLine("The number you entered is not between 0 and 4");
            }
            else if (num < 1)
            {
                Console.WriteLine("The letter grade equivalent is an F");
            }
            else if (num < 2 && num >= 1)
            {
                Console.WriteLine("The letter grade equivalent is an D");
            }
            else if (num < 3 && num >= 2)
            {
                Console.WriteLine("The letter grade equivalent is an C");
            }
            else if (num < 3.4 && num >= 3)
            {
                Console.WriteLine("The letter grade equivalent is an B");
            }
            else
            {
                Console.WriteLine("The letter grade equivalent is an A");
            }
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
