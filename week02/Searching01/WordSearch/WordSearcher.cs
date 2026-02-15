namespace WordSearch;

public class WordSearcher
{
    public static string? Find(string[] words, string word)
    {
        foreach (string item in words)
        {
            if (item == word)
            {
                return item;
            }
        }
        return null;
    }

    public static int? FindIndex(string[] words, string word)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == word)
            {
                return i;
            }
        }
        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] australianCities = { "Adelaide", "Brisbane", "Canberra", "Darwin", "Hobart", "Melbourne", "Perth", "Sydney" };

        System.Console.Write("Enter an Australian city name to search: ");
        string? userInput = System.Console.ReadLine();

        if (userInput != null)
        {
            string? resultWord = WordSearcher.Find(australianCities, userInput);
            int? resultIndex = WordSearcher.FindIndex(australianCities, userInput);

            if (resultWord != null)
            {
                System.Console.WriteLine($"Result: Found '{resultWord}' at index {resultIndex}.");
            }
            else
            {
                System.Console.WriteLine("Result: City not found in the list.");
            }
        }
    }
}