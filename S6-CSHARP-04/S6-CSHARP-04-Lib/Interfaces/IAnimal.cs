using System.Drawing;
using S6_CSHARP_04_Lib.Enums;

namespace S6_CSHARP_04_Lib.Interfaces;

public interface IAnimal
{
    string Name { get; set; }
    Point Position { get; set; }
    void MakeSound();
    void Move(Direction direction, int step);
}