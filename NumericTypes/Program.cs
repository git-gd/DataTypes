using System;
using System.ComponentModel.DataAnnotations;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of a rectangle:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of a rectangle:");
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("The area is: " + area);
        }
    }
}
