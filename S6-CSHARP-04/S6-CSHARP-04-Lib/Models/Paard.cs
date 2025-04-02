namespace S6_CSHARP_04_Lib.Models;

public class Paard : Dier
{
    public Paard(string name, int gewicht) : base(name, gewicht) { }
    public override void MakeSound() => Console.WriteLine("Hiiiii!");
}