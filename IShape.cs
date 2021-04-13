namespace OOShapes
{
    public interface IShape
    {
        string Name { get; }
        decimal CalculatePerimeter();
        decimal CalculateArea();
    }
}