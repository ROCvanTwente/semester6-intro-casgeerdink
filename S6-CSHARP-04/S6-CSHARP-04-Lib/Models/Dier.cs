using System.Drawing;
using S6_CSHARP_04_Lib.Enums;
using S6_CSHARP_04_Lib.Interfaces;

namespace S6_CSHARP_04_Lib.Models;

public abstract class Dier : IAnimal
{
    public string Name { get; set; }
    public Point Position { get; set; }
    public static List<IAnimal> AlleDieren { get; } = new List<IAnimal>();

    protected Dier(string name, int gewicht)
    {
        Name = name;
        Position = new Point(new Random().Next(0, 1000), new Random().Next(0, 1000));
    }

    public abstract void MakeSound();

    public void Move(Direction direction, int step)
    {
        switch (direction)
        {
            case Direction.Up:
                Position = new Point(Position.X, Position.Y - step);
                break;
            case Direction.Down:
                Position = new Point(Position.X, Position.Y + step);
                break;
            case Direction.Left:
                Position = new Point(Position.X - step, Position.Y);
                break;
            case Direction.Right:
                Position = new Point(Position.X + step, Position.Y);
                break;
        }
    }
}