using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC110_11._15_Object_example_1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Mileage m = new Mileage();
            double miles = 100;
            double gallons = 10;
            double pricePerGallon = 2;

            Mileage m = new Mileage(miles, gallons, pricePerGallon);


            Console.WriteLine("Your MPG: {0}", m.GetMilesPerGallon());
            Console.WriteLine("Cost: {0}/mile", m.PricePerMile());

            Console.ReadKey();
        }
    }
}
