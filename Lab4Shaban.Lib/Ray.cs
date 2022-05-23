namespace Lab4Shaban.Lib;

public class Ray : SimpleFigure, ICloneable, IEquatable<Ray>
{
    public Point Vector { get; }

    public bool Cross0X { get; private set; }

    public bool Cross0Y { get; private set; }

    public Ray(Point vertex, Point vector) : base(vertex)
    {
        Vector = vector;

        Cross0X = IsCrossing(Vertex.Y, Vector.Y);
        Cross0Y = IsCrossing(Vertex.X, Vector.X);
    }

   
    public Ray(double vertexX, double vertexY, double vectorX, double vectorY) : base(vertexX, vertexY)
    {
        Vector = new Point(vectorX, vectorY);

        Cross0X = IsCrossing(Vertex.Y, Vector.Y);
        Cross0Y = IsCrossing(Vertex.X, Vector.X);
    }


    public bool Equals(Ray? other)
    {
        return Equals(this, other);
    }

    public override bool Equals(object? obj)
    {
        return obj is Ray ray && Vertex == ray.Vertex && Vector == ray.Vector;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Vertex, Vector);
    }

    public override string ToString()
    {
        return "Vertex:" + Vertex + ", Vector:" + Vector;
    }

    public object Clone()
    {
        return new Ray(Vertex, Vector);
    }

    public override void AddVertexValue(Point value)
    {
        base.AddVertexValue(value);

        Cross0X = IsCrossing(Vertex.Y, Vector.Y);
        Cross0Y = IsCrossing(Vertex.X, Vector.X);
    }

    public static bool IsParallel(Ray first, Ray second)
    {
        double firstCalc = (first.Vector.Y - first.Vertex.Y) / (first.Vector.X - first.Vertex.X);
        double secondCalc = (second.Vector.Y - second.Vertex.Y) / (second.Vector.X - second.Vertex.X);

        return firstCalc == secondCalc || (firstCalc is double.NaN && secondCalc is double.NaN);
    }

    private bool IsCrossing(double vertex, double vector)
    {
        var c = vector - vertex;
        return c > 0 && vertex <= 0 || c < 0 && vertex >= 0;
    }
}