namespace EvenOrOdd;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer.");
       
        string input = Console.ReadLine() ?? "";


        if (int.TryParse(input, out int a))
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}
