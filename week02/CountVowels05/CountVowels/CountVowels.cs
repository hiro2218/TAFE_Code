namespace CountVowels;

public class CountVowels
{
    public static int[] Count(string line)
    {
        int[] counts = new int[5];

        if (line == null) return counts;

        foreach (char c in line.ToLower())
        {
            switch (c)
            {
                case 'a':
                    counts[0]++;
                    break;
                case 'e':
                    counts[1]++;
                    break;
                case 'i':
                    counts[2]++;
                    break;
                case 'o':
                    counts[3]++;
                    break;
                case 'u':
                    counts[4]++;
                    break;
            }
        }

        return counts;
    }

    public static void Main()
    {
        Console.Write("Enter a string to count vowels: ");
        string input = Console.ReadLine() ?? "";

        int[] results = Count(input);

        Console.WriteLine("\nVowel Counts:");
        Console.WriteLine($"'a': {results[0]}");
        Console.WriteLine($"'e': {results[1]}");
        Console.WriteLine($"'i': {results[2]}");
        Console.WriteLine($"'o': {results[3]}");
        Console.WriteLine($"'u': {results[4]}");
    }
}