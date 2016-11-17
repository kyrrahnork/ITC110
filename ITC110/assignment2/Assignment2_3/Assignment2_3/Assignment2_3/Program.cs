using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    /* This will have the user enter a meal amount.
       Enter the tip percentage as a whole number 15, 20 etc.
       Make Tax a constant at .092. Program will then output, the amount, the tip
      (and after dividing the tip percent by 100), the tax and the total.
    */
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
            Console.WriteLine("Enter what percentage you want to to tip (please enter as a whole number...10, 15, 20, etc."); //ask for tip percentage
            double tip = double.Parse(Console.ReadLine()); //parse as a number
            double tax = .092;
            double tax2 = meal * tax;
            double mealplustax = tax2 + meal;
            double tip2 = tip/100 * mealplustax;
            double total = tip2 + tax2 + meal;
            Console.WriteLine("Meal Price: {0}", meal);
            Console.WriteLine("Tip:@ {0}% = ${1}", tip, tip2);
            Console.WriteLine("Tax: @ 9.2% = ${0}", tax2);
            Console.WriteLine("___________________");
            Console.WriteLine("Total: ${0}", total);
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
