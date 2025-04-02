namespace S6_CSHARP_02.Interfaces;

public interface IVehicle
{
    int Speed { get; }
    int NumberOfWheels { get; }
    string Color { get; set; }

    void Accelerate(int amount);
    void Decelerate(int amount);
    string GetSpeed();
}