using S6_CSHARP_02.Interfaces;

namespace S6_CSHARP_02;

public class Circle : IShape
{
    public double Radius { get; private set; }
    public double Area => Math.PI * Radius * Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public void Resize(double factor)
    {
        Radius *= factor;
    }
}