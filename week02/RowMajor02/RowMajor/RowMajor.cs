using System;

namespace RowMajor;

public class RowMajorArray
{
    private readonly int[] _array;
    public int Width { get; private set; }
    public int Height { get; private set; }

    public RowMajorArray(int[] array, int width, int height)
    {
        this._array = array;
        this.Width = width;
        this.Height = height;
    }

    public int Get(int x, int y)
    {
        int index = (y * Width) + x;
        return _array[index];
    }

    public void Set(int x, int y, int v)
    {
        int index = (y * Width) + x;
        _array[index] = v;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of columns (Width): ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of rows (Height): ");
        int height = int.Parse(Console.ReadLine());

        int totalElements = width * height;
        int[] userData = new int[totalElements];

        for (int i = 0; i < totalElements; i++)
        {
            Console.Write($"Element {i}: ");
            userData[i] = int.Parse(Console.ReadLine());
        }

        RowMajorArray myGrid = new RowMajorArray(userData, width, height);

        Console.Write($"Enter X coordinate (0 to {width - 1}): ");
        int targetX = int.Parse(Console.ReadLine());

        Console.Write($"Enter Y coordinate (0 to {height - 1}): ");
        int targetY = int.Parse(Console.ReadLine());

        int result = myGrid.Get(targetX, targetY);
        Console.WriteLine($"Value: {result}");
    }
}