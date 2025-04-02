namespace S6_CSHARP_04_Lib.Models;

public class Kip : Dier
{
    public Kip(string name, int gewicht) : base(name, gewicht) { }
    public override void MakeSound() => Console.WriteLine("Tok tok!");
}