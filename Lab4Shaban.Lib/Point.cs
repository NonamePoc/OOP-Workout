namespace Lab4Shaban.Lib;

public struct Point
{
    public double X { get; private set; }
    public double Y { get; private set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object? obj)
    {
        return obj is Point point && X == point.X && Y == point.Y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public override string ToString()
    {
        return "X=" + X + ", Y=" + Y;
    }

    public static bool operator ==(Point left, Point right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Point left, Point right)
    {
        return !left.Equals(right);
    }

    public static Point operator +(Point left, Point right)
    {
        return new Point
        {
            X = left.X +right.X,
            Y = left.Y + right.Y
        };
    }

    public static Point operator -(Point left, Point right)
    {
        return new Point
        {
            X = left.X -right.X,
            Y = left.Y - right.Y
        };
    }
}
