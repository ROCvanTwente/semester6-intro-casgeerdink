namespace S6_CSHARP_02.Interfaces;

public interface IShape
{
    double Area { get; }
    double CalculatePerimeter();
    void Resize(double factor);
}