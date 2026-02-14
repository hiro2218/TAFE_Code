// See https://aka.ms/new-console-template for more information

namespace SquareNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number to square: ");
        
        string input = Console.ReadLine() ?? string.Empty;

        if (int.TryParse(input, out int number))
        {
            int square = number * number;
            
            Console.WriteLine(square);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}
