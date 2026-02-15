namespace AddingArrays;
using System;

public class AddingArrays
{
    public static int[] Join(int[] arrayA, int[] arrayB)
    {
        int totalLength = arrayA.Length + arrayB.Length;
        int[] resultArray = new int[totalLength];

        for (int i = 0; i < arrayA.Length; i++)
        {
            resultArray[i] = arrayA[i];
        }

        for (int j = 0; j < arrayB.Length; j++)
        {
            resultArray[arrayA.Length + j] = arrayB[j];
        }

        return resultArray;
    }

    public static void Main()
    {
        int[] a = GetArrayFromUser("first");
        int[] b = GetArrayFromUser("second");

        int[] combined = Join(a, b);

        Console.WriteLine("\nCombined Array:");
        Console.WriteLine(string.Join(", ", combined));
    }

    private static int[] GetArrayFromUser(string label)
{
    Console.Write($"Enter the number of elements for the {label} array: ");
    int count = int.Parse(Console.ReadLine() ?? "0");
    int[] array = new int[count];

    for (int i = 0; i < count; i++)
    {
        Console.Write($"Enter value for index {i}: ");
        array[i] = int.Parse(Console.ReadLine() ?? "0");
    }

    return array;
}
}