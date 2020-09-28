using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles were driven?");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("How many miles of gas were consumed?");
            double gallons = double.Parse(Console.ReadLine());
            double mpg = miles / gallons;
            Console.WriteLine(mpg + " mpg");
        }
    }
}
