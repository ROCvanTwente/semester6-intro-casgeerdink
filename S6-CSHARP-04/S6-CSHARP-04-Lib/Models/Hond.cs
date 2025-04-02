namespace S6_CSHARP_04_Lib.Models;

public class Hond : Dier
{
    public Hond(string name, int gewicht) : base(name, gewicht) { }
    public override void MakeSound() => Console.WriteLine("hond blaft!");
}
