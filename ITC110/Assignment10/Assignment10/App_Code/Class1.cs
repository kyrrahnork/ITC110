using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class MealOrder
{
    public List<string> Sizes { set; get; }
    public List<string> Toppings { set; get; }
    public MealOrder()
    {
        Sizes = new List<string>();
        Toppings = new List<string>();
    }

    public void AddSizes(string item)
    {
        Sizes.Add(item);
    }

    public void AddToppings(string item)
    {
        Toppings.Add(item);
    }

    public double Calculatetotal()
    {
        double total = 0;
        foreach (string size in Sizes)
        {
            if (size == "Small: 14in.")
            {
                total += 12.99;
            }
            else if(size == "Medium: 16in.")
            {
                total += 15.99;
            }
            else if (size == "Large: 18in.")
            {
                total += 17.99;
            }
        }
        foreach (string topping in Toppings)
            {
                total += 1;
            }
        return total;
    }
}