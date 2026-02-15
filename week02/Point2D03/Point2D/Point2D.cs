namespace Point2D;

public class Point2D
{
    private double _x;
    private double _y;

    public Point2D(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public double GetX()
    {
        return _x;
    }

    public double GetY()
    {
        return _y;
    }

    public double[] GetCoords()
    {
        return new double[] { _x, _y };
    }
}