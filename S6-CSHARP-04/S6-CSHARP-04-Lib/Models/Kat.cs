namespace S6_CSHARP_04_Lib.Models;

public class Kat : Dier
{
    public Kat(string name, int gewicht) : base(name, gewicht) { }
    public override void MakeSound() => Console.WriteLine("Miauw!");
}