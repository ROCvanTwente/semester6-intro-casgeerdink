using S6_CSHARP_02.Interfaces;

namespace S6_CSHARP_02;

public class Bicycle : IVehicle
{
    public int Speed { get; private set; }
    public int NumberOfWheels { get; } = 2;
    public string Color { get; set; }

    public Bicycle(string color)
    {
        Color = color;
    }

    public void Accelerate(int amount)
    {
        Speed += amount;
    }

    public void Decelerate(int amount)
    {
        Speed = Speed - amount < 0 ? 0 : Speed - amount;
    }

    public string GetSpeed()
    {
        return $"De fiets rijdt {Speed} km/u.";
    }
}