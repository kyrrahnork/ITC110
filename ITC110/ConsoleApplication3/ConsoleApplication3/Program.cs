using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            Console.WriteLine("Enter the items and prices");
            for( int i = 0; i<10; i++)
            {
                Item item = new Item();
                Console.WriteLine("Item name");
                item.ItemName = Console.ReadLine();
                Console.WriteLine("Item Price");
                item.Price = double.Parse(Console.ReadLine());
                cart.AddItems(item, i);
            }

            double total = cart.Total();
            Console.WriteLine(total);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
