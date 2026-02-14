namespace MinSearch;

public class MinSearch
{
    public static void Main(string[] args)
    {
        int[] userNumbers = new int[5];
        Console.WriteLine("Please enter 5 integers:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Number {i + 1}: ");
            string input = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(input, out int parsedNumber))
            {
                userNumbers[i] = parsedNumber;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
                i--; 
            }
        }

        int? smallest = Find(userNumbers);

        if (smallest.HasValue)
        {
            Console.WriteLine($"\nThe smallest number entered is: {smallest}");
        }
    }

    public static int? Find(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return null;
        }

        int currentMin = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < currentMin)
            {
                currentMin = numbers[i];
            }
        }

        return currentMin;
    }
}