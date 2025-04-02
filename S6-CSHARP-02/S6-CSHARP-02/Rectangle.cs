using S6_CSHARP_02.Interfaces;

namespace S6_CSHARP_02;

public class Rectangle : IShape
{
    public double Width { get; private set; }
    public double Height { get; private set; }
    public double Area => Width * Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }

    public void Resize(double factor)
    {
        Width *= factor;
        Height *= factor;
    }
}