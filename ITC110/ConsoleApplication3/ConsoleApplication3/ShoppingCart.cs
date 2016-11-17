using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
     public class ShoppingCart
    {
        private Item[] myList;

        public ShoppingCart()
        {
            myList = new Item[10];
        }

        public void AddItems(Item i, int counter)
        {
            myList[counter] = i;
        }

        public double Total()
        {
            double total = 0;
            foreach(Item i in myList)
            {
                total += i.Price;
            }
           return total;
        }

    }
}
