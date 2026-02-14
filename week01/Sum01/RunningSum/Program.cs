// See https://aka.ms/new-console-template for more information

namespace RunningSum;

public class Program
{
    public static void Main(string[] args)
    {
        int runningTotal = 0;
        Console.WriteLine("Keep entering a number to display a running sum. If no more number to enter, press Enter.");
        Console.WriteLine();

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                runningTotal += number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
            }
        }

        Console.WriteLine();
        Console.WriteLine($"The total is: {runningTotal}");
    }
}
