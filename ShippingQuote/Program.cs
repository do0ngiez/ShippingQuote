using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //weight
            Console.Write("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
                //exit program
                return;
            }

            //width
            Console.Write("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            //height
            Console.Write("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            //length
            Console.Write("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            //stored dimensions to var
            int dimensions = width + height + length;
            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
                //exit program
                return;
            }

            int dimensionsFinal = width * height * length;
            decimal quote = (dimensionsFinal * weight) / 100m;

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}
