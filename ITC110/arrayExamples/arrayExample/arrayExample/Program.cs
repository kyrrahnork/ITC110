using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            myArray[0] = 1;
            myArray[1] = 3;
            myArray[2] = 14;
            myArray[3] = 12;
            myArray[4] = 8;

            Console.WriteLine("the third element is {0}", myArray[2]);
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
