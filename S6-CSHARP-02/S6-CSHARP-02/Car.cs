using S6_CSHARP_02.Interfaces;

namespace S6_CSHARP_02;

public class Car : IVehicle
{
    public int Speed { get; private set; }
    public int NumberOfWheels { get; } = 4;
    public string Color { get; set; }

    public Car(string color)
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
        return $"De auto rijdt {Speed} km/u.";
    }
}