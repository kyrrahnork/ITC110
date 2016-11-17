using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  For this one, use the tip assignment from 3 in Assignment 2, Change it so the user can enter
a decimal or a whole number for the tip percent. So if the percent is greater than 1 divide by 100 otherwise use the decimal they provided.
*/
namespace NorkAssignment3_1
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
            Console.WriteLine("Please enter the price of your meal."); //ask for meal price
            double meal = double.Parse(Console.ReadLine()); //parse price as a number
            Console.WriteLine("Enter what percentage you want to to tip (feel free to enter either a whole number or decimal."); //ask for tip percentage
            double tip = double.Parse(Console.ReadLine()); //parse as a number
            if (tip > 1)
            {
                tip = tip / 100; //if tip entered is greater tha 1, divide by 100
            }
            else
            {
                tip = tip; // if tip entered as decimal, use it as is
            }
            double tax = .092;
            double tax2 = meal * tax;
            double mealplustax = tax2 + meal;
            double tip2 = tip * mealplustax;
            double total = tip2 + tax2 + meal;
            Console.WriteLine("Meal Price: {0}", meal);
            Console.WriteLine("Tip:@ {0}% = ${1:0.00}", tip, tip2);
            Console.WriteLine("Tax: @ 9.2% = ${0:0.00}", tax2);
            Console.WriteLine("___________________");
            Console.WriteLine("Total: ${0}", total);
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}