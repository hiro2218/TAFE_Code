namespace Grades;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your mark: ");
        string input = Console.ReadLine() ?? string.Empty;


        if (int.TryParse(input, out int mark))
        {
            if (mark >= 85)
            {
                Console.WriteLine("A");
            }
            else if (mark >= 75)
            {
                Console.WriteLine("B");
            }
            else if (mark >= 65)
            {
                Console.WriteLine("C");
            }
            else if (mark >= 50)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric mark.");
        }
    }
}



