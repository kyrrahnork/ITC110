using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC110_11._15_Object_example_1
{
    public class Mileage
    {
        //fields -- class level variable that describes the class
        private double miles;
        private double gallons;
        private double pricePerGallon;

        //constructor (special method which initializes [sort of] class)
     /*   public Mileage()
        {
            Miles = 0;
            Gallons = 0;
            PricePerGallon = 0;
        }*/

        public Mileage(double totalMiles, double totalGallons, double gallonPrice)
        {
            Miles = totalMiles;
            Gallons = totalGallons;
            PricePerGallon = gallonPrice;
        }

        //properties expose private fields to other classes 
        //set lets teh variable be changed
        //get returns the value of the variable

        public double Miles
        {
            get
            {
                return miles;
            }

            set
            {
                miles = value;
            }
        }

        public double Gallons
        {
            get
            {
                return gallons;
            }

            set
            {
                gallons = value;
            }
        }

        public double PricePerGallon
        {
            get
            {
                return pricePerGallon;
            }

            set
            {
                pricePerGallon = value;
            }
        }
        //public methods
        public double GetMilesPerGallon()
        {
            return Miles / Gallons;
        }              
        public double PricePerMile()
        {
            double total = PricePerGallon * Gallons;
            return total / Miles;
        }
    }
}
