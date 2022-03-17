using System;
using System.Threading;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter package weight:");
            float weight = float.Parse(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter package width:");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter package height:");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter package length:");
            float length = float.Parse(Console.ReadLine());
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            float quote = weight * width * height * length / 100;
            Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C"));
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
