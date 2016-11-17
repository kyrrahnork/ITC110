using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorkAssignment5_3
{
    /*This program will create an array of 10 doubles.
     *Then it will prompt a user to enter numbers into the array.
     * After all the numbers have been entered
     * it will display all the numbers in the array, the total of the numbers
     * and the average.
     */
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[10];
            Console.WriteLine("Please enter 10 numbers.");
            

            for (int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine("Please enter your number.");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            foreach(double x in numbers)
            {
                Console.WriteLine(x);
            }

            double sum = numbers.Sum();
            Console.WriteLine("The sum of all of the numbers you entered is: {0}", sum);

            double avg = sum / numbers.Length;
            Console.WriteLine("The average of all of the numbers you entered is: {0}", avg);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
