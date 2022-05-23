namespace Lab4Shaban.Lib;

public abstract class SimpleFigure : IFigure
{
    public Point Vertex { get; protected set; }
    protected SimpleFigure(Point vertex)
    {
        Vertex = vertex;
    }

    protected SimpleFigure(double vertexX, double vertexY)
    {
        Vertex = new Point(vertexX, vertexY);
    }

    public virtual void AddVertexValue(Point value)
    {
        Vertex += value;
    }
    
    public string GetInfo()
    {
        return ToString();
    }
}