using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_1
{
    public class Total
    {
        private double mealPrice;
        private double tip;

        public Total()
        {
            MealPrice = 0;
            Tip = 0;
        }

        public Total(double totalMealPrice, double totalTip)
        {
            MealPrice = totalMealPrice;
            Tip = totalTip;     
        }

        public double MealPrice
        {
            get
            {
                return mealPrice;
            }
            set
            {
                mealPrice = value;
            }
        }

        public double Tip
        {
            get
            {
                return tip;
            }
            set
            {
                tip = value;
            }
        }

        public double GetTax()
        {
            double tax = .09;
            return MealPrice * tax;
        }

        public double BillTip()
        {
            return (GetTax() + MealPrice) * Tip;
        }

        public double TotalBill()
        {
            return GetTax() + BillTip() + MealPrice;
        }
    }
}
