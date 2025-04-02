namespace S6_CSHARP_04_Lib.Models;

public class Varken : Dier
{
    public Varken(string name, int gewicht) : base(name, gewicht) { }
    public override void MakeSound() => Console.WriteLine("Knor knor!");
}