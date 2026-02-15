namespace Point2D;

public class Line
{
    public static void Main(string[] args)
    {
        // Example 1
        Point2D a1 = new Point2D(2.0, 3.5);
        Point2D b1 = new Point2D(1.0, 3.5);
        Point2D? p1 = FindPoint(a1, b1, 0.5);
        Console.WriteLine("--- Example 1 ---");
        Console.WriteLine(p1 != null ? $"Result: x={p1.GetX()}, y={p1.GetY()}" : "Result: null");

        // Example 2
        Point2D a2 = new Point2D(2.0, 5.5);
        Point2D b2 = new Point2D(2.0, 3.5);
        Point2D? p2 = FindPoint(a2, b2, 0.5);
        Console.WriteLine("\n--- Example 2 ---");
        Console.WriteLine(p2 != null ? $"Result: x={p2.GetX()}, y={p2.GetY()}" : "Result: null");

        // Example 3
        Point2D a3 = new Point2D(2.0, 5.5);
        Point2D b3 = new Point2D(2.0, 3.5);
        Point2D? p3 = FindPoint(a3, b3, 1.5);
        Console.WriteLine("\n--- Example 3 ---");
        Console.WriteLine(p3 != null ? $"Result: x={p3.GetX()}, y={p3.GetY()}" : "Result: null");
    }

    public static Point2D? FindPoint(Point2D a, Point2D b, double d)
    {
        if (d < 0.0 || d > 1.0)
        {
            return null;
        }

        double x = a.GetX() + ((b.GetX() - a.GetX()) * d);
        double y = a.GetY() + ((b.GetY() - a.GetY()) * d);

        return new Point2D(x, y);
    }
}