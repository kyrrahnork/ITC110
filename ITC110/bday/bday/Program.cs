using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bday
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            int age;
            int years;
            int month;
            DateTime birthday;
            Console.WriteLine("enter your birth date");
            bool goodDate = DateTime.TryParse(Console.ReadLine(), out birthday);

            if(!goodDate)
            {
                Console.WriteLine("enter a valid date");
                bool good = DateTime.TryParse(Console.ReadLine(), out birthday);
                if(!good)
                {
                    Console.WriteLine("sorry still not valid");
                    Console.WriteLine("press any key to exit");
                    Console.ReadKey();
                    return;
                }
            }
            age = today.Year - birthday.Year;
            Console.WriteLine("you are {0} years old", age);
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
