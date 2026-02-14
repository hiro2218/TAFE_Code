// See https://aka.ms/new-console-template for more information

using System;

namespace Timetables;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
       
        string input = Console.ReadLine() ?? string.Empty;

        if (int.TryParse(input, out int number))
        {
            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

