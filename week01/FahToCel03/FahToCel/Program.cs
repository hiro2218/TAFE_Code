using System;

namespace FahToCel03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature in Fahrenheit: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit}°F is equivalent to {celsius:F2}°C.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical value.");
            }
        }
    }
}